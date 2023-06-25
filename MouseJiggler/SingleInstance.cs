#region header

// MouseJiggler - MainForm.cs
// 
// Created by: Alistair J R Young (avatar) at 2021/01/24 1:57 AM.

#endregion

#region using

using System;
using System.Threading;
using System.Windows.Forms;

#endregion

namespace ArkaneSystems.MouseJiggler
{
    public static class SingleInstance
    {
        public static readonly int WM_SHOWFIRSTINSTANCE =
            WinApi.RegisterWindowMessage("WM_SHOWFIRSTINSTANCE|{0}", ProgramInfo.AssemblyGuid);

        static Mutex mutex;

        static public bool Start()
        {
            string mutexName = ProgramInfo.AssemblyGuid;

            // if you want your app to be limited to a single instance
            // across ALL SESSIONS (multiple users & terminal services), then use the following line instead:
            // string mutexName = String.Format("Global\\{0}", ProgramInfo.AssemblyGuid);

            mutex = new Mutex(true, mutexName, out bool onlyInstance);
            return onlyInstance;
        }

        static public void ShowFirstInstance()
        {
            MessageBox.Show("Already Running");

            WinApi.PostMessage(
                (IntPtr)WinApi.HWND_BROADCAST,
                WM_SHOWFIRSTINSTANCE,
                IntPtr.Zero,
                IntPtr.Zero);
        }

        static public void Stop()
        {
            mutex.ReleaseMutex();
        }
    }
}
