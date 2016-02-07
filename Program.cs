using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Snapping
{
    class Program
    {
        static void Main(string[] args)
        {
            //IntPtr test = new IntPtr(); When reading values
            //StringBuilder builder = new StringBuilder();

            SystemParametersInfo(0x0091, 0, IntPtr.Zero, 0x001A);

            //0x0083 complete snapping
            //0x0090 get dock moving
            //0x0091 set dock moving
            //0x008F set snap sizing
            //SPI_GETMOUSESIDEMOVETHRESHOLD = 0x0088,
            //SPI_SETMOUSESIDEMOVETHRESHOLD = 0x0089,
            //SPI_GETMOUSEDRAGOUTTHRESHOLD = 0x0084,
            //SPI_GETMOUSEDOCKTHRESHOLD = 0x007E,

            //Full list of values found here:
            //https://msdn.microsoft.com/en-us/library/windows/desktop/ms724947(v=vs.85).aspx
        }

        //[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        //static extern bool SendNotifyMessage(IntPtr hWnd, uint Msg, UIntPtr wParam, string lParam);

        //public static void NotifyUserEnvironmentVariableChanged()
        //{
        //    const int HWND_BROADCAST = 0xffff;
        //    const uint WM_SETTINGCHANGE = 0x001a;
        //    SendNotifyMessage((IntPtr)HWND_BROADCAST, WM_SETTINGCHANGE, (UIntPtr)0, "Environment");
        //}

        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
        public static extern bool SystemParametersInfo(int uiAction, int uiParam, IntPtr pvParam, int fWinIni);

        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
        public static extern bool SystemParametersInfo(int uiAction, int uiParam, StringBuilder pvParam, int fWinIni);
    }

}
