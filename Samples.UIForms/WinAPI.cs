using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Samples.UIForms
{
    internal static partial class WinAPI
    {
        [LibraryImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        /// Adiciona bordar arredondas em controles
        /// Ex.: this.Region = Region.FromHrgn(WinAPI.CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        private static partial IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nButtonRect,
                                                       int nWidthEllipse, int nHeightEllipse);
        public static void BorderRadios(this Control control, int cornerSize)
        {
            control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, cornerSize, cornerSize));
        }

        public enum EFlagAnimate
        {
            H_POSITIVE = 0X1,
            H_NEGATIVE = 0X2,
            V_POSITIVE = 0X4,
            V_NEGATIVE = 0X8,
            SLIDE = 0X40000,
            CENTER = 0X10,
            BLEND = 0X80000,
        }
        [LibraryImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static partial bool AnimateWindow(IntPtr hwnd, int time, int flag);

        public static void Animate(this Form form, int milliseconds, EFlagAnimate eFlag)
        {
            AnimateWindow(form.Handle, milliseconds, (int)eFlag);
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        //public const int WM_LBUTTONDOWN = 0x0201;

        [LibraryImport("user32.dll")]
        public static partial int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [LibraryImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool ReleaseCapture();

        static public void Drag(IntPtr hWnd)
        {
            ReleaseCapture();
            _ = SendMessage(hWnd, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
