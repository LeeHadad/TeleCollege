using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct a
        {
            public int i;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string b;
        };

        [DllImport("C:\\Users\\User\\source\\repos\\Project3\\Debug\\Project3.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr testRet(out int length);

        [DllImport("C:\\Users\\User\\source\\repos\\Project3\\Debug\\Project3.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int rem(IntPtr arr);
        public Form1()
        {
            InitializeComponent();

        }

        public static void MarshalUnmananagedArray2Struct<T>(IntPtr unmanagedArray, int length, out List<T> mangagedArray)
        {
            var size = Marshal.SizeOf(typeof(T));
            mangagedArray = new List<T>();

            for (int i = 0; i < length; i++)
            {
                IntPtr ins = new IntPtr(unmanagedArray.ToInt64() + i * size);
                mangagedArray.Add(Marshal.PtrToStructure<T>(ins));
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<a> lst;
            int length;
            IntPtr pointer = testRet(out length);
            MarshalUnmananagedArray2Struct(pointer, length, out lst);

            Debug.WriteLine(rem(pointer));
            Debug.WriteLine(lst.Count);
            lst.RemoveAt(3);
            Debug.WriteLine(lst.Count);
            _text.Text =lst[3].i.ToString();


        }
    }
}
