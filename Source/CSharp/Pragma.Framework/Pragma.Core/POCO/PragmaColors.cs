using System;
using System.Drawing;

namespace Pragma.Core
{
    public static class PragmaColor
    {
        /// <summary>
        /// Cor para definir ações de sucesso.
        /// </summary>
        public static Color VerdeSucess = Color.FromArgb(205, 255, 205);
        /// <summary>
        /// Cor para definir ações de erro.
        /// </summary>
        public static Color VermelhoError = Color.FromArgb(255, 205, 205);
        /// <summary>
        /// Cor para definir ações de alerta.
        /// </summary>
        public static Color AmareloAlert = Color.FromArgb(255, 255, 220);
        /// <summary>
        /// Cor para definir ações de desativado.
        /// </summary>
        public static Color CinzaDisabled = Color.FromArgb(230, 230, 230);
        /// <summary>
        /// Preto padrão.
        /// </summary>
        public static Color DisabledControlText = Color.FromArgb(160, 160, 160);
        /// <summary>
        /// Branco padrão.
        /// </summary>
        public static Color Branco = Color.White;
        /// <summary>
        /// Preto padrão.
        /// </summary>
        public static Color Preto = Color.Black;
        /// <summary>
        /// Vermelho do logo da Pragma
        /// </summary>
        public static Color VermelhoPragma = Color.FromArgb(192, 0, 0);

        public static Color CinzaLinhaDataGrid = Color.FromArgb(240, 240, 240);

        //LEMBRAR QUE O RED E O BLUE ESTÃO INVERTIDOS!
        public static int vermelhoPragma = Color.FromArgb(0, 0, 0, 192).ToArgb();
        public static int cinzaClaroLinha = Color.FromArgb(0, 232, 232, 232).ToArgb();
        public static int cinzaNumeracaoSlide = Color.FromArgb(0, 137, 137, 137).ToArgb();
        public static int cinzaListrasTabela = Color.FromArgb(0, 234, 234, 234).ToArgb();
        public static int cinzaMuitoClaro = Color.FromArgb(0, 242, 242, 242).ToArgb();
        public static int cinzaMaisClaro = Color.FromArgb(0, 237, 237, 237).ToArgb();
        public static int cinzaMeioClaro = Color.FromArgb(0, 192, 192, 192).ToArgb();
        public static int cinzaClaro = Color.FromArgb(0, 162, 162, 162).ToArgb();
        public static int cinzaEscuro = Color.FromArgb(0, 128, 128, 128).ToArgb();

        public static int rosaClaro = Color.FromArgb(0, 205, 206, 238).ToArgb();
        public static int rosaEscuro = Color.FromArgb(0, 169, 169, 240).ToArgb();
        public static int vinho = Color.FromArgb(64, 64, 128).ToArgb();

        //Usados no gráfico de barras do slide de Alocação por Classe de Ativo
        public static int cinzaLocal = Color.FromArgb(0, 180, 180, 180).ToArgb();
        public static int rosaInternacional = Color.FromArgb(0, 148, 150, 218).ToArgb();


        /// <summary>
        /// Transforma o RGB em um numero unico
        /// </summary>
        /// <param name="tR">Vermelho 0-255</param>
        /// <param name="tG">Verde 0-255</param>
        /// <param name="tB">Azul 0-255</param>
        /// <returns>retorna a color como inteiro</returns>
        public static int ToRgb(int tR, int tG, int tB)
        {
            var bytes = new byte[4];
            bytes[0] = (byte)tR;
            bytes[1] = (byte)tG;
            bytes[2] = (byte)tB;

            return BitConverter.ToInt32(bytes, 0);
        }

        /// <summary>
        /// Faz a conversão de uma cor base em uma nova cor, usada principalmente
        /// para converter icones pretos em coloridos.
        /// </summary>
        /// <param name="baseColor">Cor original.</param>
        /// <param name="newColor">Cor de destino.</param>
        /// <returns>Cor convertida.</returns>
        public static Color ColorShift(Color baseColor, Color newColor)
        {
            return Color.FromArgb(baseColor.A,
                                  ByteShift(baseColor.R, newColor.R),
                                  ByteShift(baseColor.G, newColor.G),
                                  ByteShift(baseColor.B, newColor.B));
        }
        /// <summary>
        /// Calcula o byte da conversão de cor.
        /// </summary>
        /// <param name="orig">byte original.</param>
        /// <param name="dest">byte destino.</param>
        private static int ByteShift(int orig, int dest)
        {
            return dest + ((orig * (255 - dest)) / 255);
        }
    }
}
