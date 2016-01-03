using System;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;

    //
    //This class is responsible for setting the screen brightness
    //

    class Brightness
    {
        public const byte minimumBrightness = 10;
        public const byte maximumBrightness = 110;

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]

        public struct RAMP

        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Red;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Green;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Blue;
        }


        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hWnd);
        [DllImport("gdi32.dll")]
        static extern bool GetDeviceGammaRamp(IntPtr hdc, ref RAMP lpRamp);
        [DllImport("gdi32.dll")]
        static extern bool SetDeviceGammaRamp(IntPtr hdc, ref RAMP lpRamp);

        private static RAMP initialRAMP;

        private static byte currentBrightness;

        static Brightness()
        {
            GetDeviceGammaRamp(GetDC(IntPtr.Zero), ref initialRAMP);
            currentBrightness = GetBrightnessFromRAMP(initialRAMP);
        }

        public static bool SetBrightness(byte brightness)
        {
            if (brightness < minimumBrightness || brightness > maximumBrightness) return false;
            currentBrightness = brightness;
            RAMP c_Ramp = CalcRAMP(brightness);
            SetDeviceGammaRamp(GetDC(IntPtr.Zero), ref c_Ramp);
            return true;
        }

        private static byte GetBrightnessFromRAMP(RAMP p_Ramp)
        {
            return (byte)(p_Ramp.Blue[1] - 128);
        }

        private static RAMP CalcRAMP(byte p_Brightness)

        {
            RAMP c_Ramp = new RAMP { Red = new ushort[256], Green = new ushort[256], Blue = new ushort[256] };
            for (int c_Index = 0; c_Index < 256; c_Index++)
            {
                c_Ramp.Red[c_Index] = (ushort)(c_Index * (p_Brightness + 128));
                c_Ramp.Green[c_Index] = (ushort)(c_Index * (p_Brightness + 128));
                c_Ramp.Blue[c_Index] = (ushort)(c_Index * (p_Brightness + 128));
            }
            return c_Ramp;
        }
    }
