using System;
using System.Drawing;

namespace Pragma.Core
{
    public static class ColorTool
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
    
        public static Color MetroRed = Color.FromArgb(192, 0, 0);
        public static Color CinzaLinhaDataGrid = Color.FromArgb(240, 240, 240);

       

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
