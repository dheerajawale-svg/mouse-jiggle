#region header

// MouseJiggler - MainForm.cs
// 
// Created by: Alistair J R Young (avatar) at 2021/01/24 1:57 AM.

#endregion

#region using

using System.Reflection;
using System.Runtime.InteropServices;

#endregion

namespace ArkaneSystems.MouseJiggler
{
    public static class ProgramInfo
    {
        public static string AssemblyGuid
        {
            get
            {
                object[] attributes = Assembly.GetEntryAssembly()
                                    .GetCustomAttributes(typeof(GuidAttribute), false);
                if (attributes == null || attributes.Length == 0)
                {
                    return "single instance: MouseJiggler";
                }
                return ((GuidAttribute)attributes[0]).Value;
            }
        }
    }

}
