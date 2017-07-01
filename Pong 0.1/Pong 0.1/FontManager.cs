using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pong_0._1
{
    public class FontManager
    {
        private PrivateFontCollection fontCollection;

        public FontManager()
        {
            fontCollection = new PrivateFontCollection(); //Erstellen ein FontCollection
            byte[] fontData = Properties.Resources.NIAGSOL; //Font aus den Resources
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length); //Pointer Adresse für die FontData erstellen
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length); //FontData in den RAM laden
            uint dummy = 0;
            fontCollection.AddMemoryFont(fontPtr, fontData.Length); //Font zur Collection über Pointer Adresse hinzufügen
            AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);
            Marshal.FreeCoTaskMem(fontPtr);
        }

        public Font CreateFont(float size)
        {
            return new Font(fontCollection.Families[0], size);
        }

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In]ref uint pcFonts);
    }
}
