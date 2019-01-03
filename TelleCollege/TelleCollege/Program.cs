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
    public static class Courses
    {
        public static int coursesAmount = 6;
        public static int[] coursePrices = { 1600, 1200, 1350, 1100, 1500, 1500 };
    }

    public static class Discounts
    {
        public static int discountAmount = 6;
        public static string[] discountPrices = { "100","500", "1200", "25%", "10%", "50%"};
    }
    public static class Statuses
    {
        public enum status
        {
            Lead = 0,
            In_Progress = 1,
            On_Hold = 2,
            Sold = 3,
            Irrelevant = 4
        }
        public static string[] statuses = { "In Progress", "On-Hold", "Sold", "Irrelevant" };
    }
    public static class Actions
    {
        public enum action
        {
            no_change = -1,
            edited = 0,
            deleted = 1,
            added = 2
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
    public struct Time
    {
        public int hour;
        public int minutes;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct History
    {


        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 42)]
        public string representativeName;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
        public string representativeId;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 182)]
        public string Note;

        public Date date;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct Customer
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string firstname;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string lastname;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
        public string id;

        public Date birthdate;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
        public string phone;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string email;

        public int status;

        public Date inserted;

        public int history_amount;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
        public History[] history;

        [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.I1, SizeConst = 6)]
        public bool[] courses;
        [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.I1, SizeConst = 6)]
        public bool[] discounts;

        public Date callLaterDate;

        public Time callLaterTime;

    }
    public class encapsulateCustomer
    {
        public Customer customer;
        public bool isChanged = false;
        public int editHistory = (int)Actions.action.no_change;
        public int editCallLater = (int)Actions.action.no_change;
        public int HistoryIndex = -1;
    }
    public struct encapsulateString
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string userName;
    }
    public static class cppLinkage
    {
        private const string dllDir = "";
        public static void MarshalUnmananagedArray2StructList<T>(IntPtr unmanagedArray, int length, out List<T> mangagedList)
        {
            var size = Marshal.SizeOf(typeof(T));
            mangagedList = new List<T>();

            for (int i = 0; i < length; i++)
            {
                IntPtr ins = new IntPtr(unmanagedArray.ToInt64() + i * size);
                mangagedList.Add(Marshal.PtrToStructure<T>(ins));
            }
        }
        [DllImport(dllDir + "\\externalLibrary.dll", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool tryLogin([MarshalAs(UnmanagedType.LPStr, SizeConst = 10)]string id,ref encapsulateString res);

        [DllImport(dllDir + "\\externalLibrary.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int checkValidID([MarshalAs(UnmanagedType.LPStr, SizeConst = 10)]string id);

        [DllImport(dllDir + "\\externalLibrary.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr exportCustomers(out int length);

        [DllImport(dllDir + "\\externalLibrary.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void freeArray(IntPtr array);

        [DllImport(dllDir + "\\externalLibrary.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void freeGlobalList();

        [DllImport(dllDir + "\\externalLibrary.dll", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool updateDatabase(
            [MarshalAs(UnmanagedType.LPStr, SizeConst =10)]
            string id,
            Customer cust,
            int action,
            int editCallLater = (int)Actions.action.no_change,
            int editHistory = (int)Actions.action.no_change,
            int index = -1);
        [DllImport(dllDir + "\\externalLibrary.dll", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern void validateAndUpdate(
            int[] res,
            Customer cust,
            [MarshalAs(UnmanagedType.LPStr, SizeConst = 10)]
            string originalId,
            int action);
    }

}
