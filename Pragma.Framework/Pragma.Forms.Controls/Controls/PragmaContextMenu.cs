﻿using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pragma.Forms.Controls.Controls
{
    public partial class PragmaContextMenu : ContextMenuStrip
    {
        public PragmaContextMenu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Adiciona um novo menu de contexto
        /// </summary>
        /// <param name="tName">Nome do Menu</param>
        /// <param name="tMethod">Metodo que será executado ao clicar no menu</param>
        public void AddMenu(string tName, Action tMethod)
        {
            AddMenu(tName, (o, s) => tMethod.Invoke(), null);
        }

        /// <summary>
        /// Adiciona um novo menu de contexto
        /// </summary>
        /// <param name="tName">Nome do Menu</param>
        /// <param name="tMethod">Metodo que será executado ao clicar no menu</param>
        /// <param name="tIcon">Caminho do icone para o item do menu</param>
        public void AddMenu(string tName, Action tMethod, Bitmap tIcon)
        {
            AddMenu(tName, (o, s) => tMethod.Invoke(), tIcon);
        }

        /// <summary>
        /// Adiciona um novo menu de contexto
        /// </summary>
        /// <param name="tName">Nome do Menu</param>
        /// <param name="tEvent">Evento que será executado ao clicar no menu</param>
        /// <param name="tIcon">Caminho do icone para o item do menu</param>
        public void AddMenu(string tName, EventHandler tEvent, Bitmap tIcon)
        {
            InsertMenu(tName, tEvent, tIcon, Items.Count);
        }

        /// <summary>
        /// Insere um menu de contexto no Índice.
        /// </summary>
        /// <param name="tName">Nome do Menu</param>
        /// <param name="tEvent">Evento que será executado ao clicar no menu</param>
        /// <param name="tIcon">Caminho do icone para o item do menu</param>
        /// <param name="index">Indice onde o menu será adicionado</param>
        /// <param name="tAvailable">Indice se o campo deve ficar disponivel em uma grid vazia</param>
        public void InsertMenu(string tName, EventHandler tEvent, Bitmap tIcon, int index)
        {
            ToolStripItem oItem = new ToolStripMenuItem();
            oItem.Click += tEvent;
            oItem.Text = tName;

            if (tIcon == null)
                tIcon = BaseIcons.show_property;

            oItem.Image = tIcon;

            Items.Insert(index, oItem);
        }

        /// <summary>
        /// Insere um menu de contexto no Índice.
        /// </summary>
        /// <param name="tName">Nome do Menu</param>
        /// <param name="tMethod">Metodo que será executado ao clicar no menu.</param>
        /// <param name="tIcon">Caminho do icone para o item do menu.</param>
        /// <param name="index">Indice onde o menu será adicionado.</param>
        /// <param name="tAvailable">Indice se o campo deve ficar disponivel em uma grid vazia</param>
        public void InsertMenu(string tName, Action tMethod, Bitmap tIcon, int index)
        {
            if (tName != "-")
            {
                ToolStripItem oItem = new ToolStripMenuItem();
                oItem.Click += (o, s) => tMethod.Invoke();
                oItem.Text = tName;

                if (tIcon == null)
                    tIcon = BaseIcons.show_property;

                oItem.Image = tIcon;

                Items.Insert(index, oItem);
            }
            else
            {
                var sep = new ToolStripSeparator();
                Items.Insert(index, sep);
            }
        }



        /// <summary>
        /// Adiciona um separador.
        /// </summary>
        public void AddSeparator()
        {
            Items.Add("-");
        }

        /// <summary>
        /// Adiciona um separador no indice especificado.
        /// </summary>
        public void AddSeparator(int index)
        {
            InsertMenu("-", () => { }, null, index);
        }

        public void InsertAsyncMenu(string tName, Func<Task> tMethod, Bitmap tIcon, int index)
        {
            if (tName != "-")
            {
                ToolStripItem oItem = new ToolStripMenuItem();
                oItem.Click += async (o, s) => await tMethod();
                oItem.Text = tName;

                if (tIcon == null)
                    tIcon = BaseIcons.show_property;

                oItem.Image = tIcon;

                Items.Insert(index, oItem);
            }
            else
            {
                var sep = new ToolStripSeparator();
                Items.Insert(index, sep);
            }
        }
    }
}
