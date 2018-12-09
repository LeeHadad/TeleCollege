using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TelleCollege
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OriginForm());//Run the application and show the main form(origin)
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct Date
    {
        public int day;
        public int month;
        public int year;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct History
    {
        public Date date;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 42)]
        public string representativeName;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
        public string representativeId;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 184)]
        public string note;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct Client
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string firstName;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string lastName;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
        public string id;

        public Date birthdate;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
        public string phone;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string email;

        public int status;

        public Date insertionDate;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public bool[] courses;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
        public History[] history;

        int history_amount;

        public IntPtr Next;
    }


}
