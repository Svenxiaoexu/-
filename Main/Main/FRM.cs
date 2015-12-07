using System;
using System.IO;
using System.Net;
using System.Text;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

namespace Main
{
    class FRM
    {
        public int i = 0;
        private static FRM instance = new FRM();
        public static FRM Instance
        {
            get { return instance; }
            set { }
        }

        public  List<string> Address = new List<string>();
        public  List<string> Format = new List<string>();

        THM b = new THM();
        public void FileRead()
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\Users\seven\Desktop\test.txt");
            System.Console.WriteLine("                        下载地址分别为  ");

            foreach (string line in lines)
            {
                i++;
                Address.Add(line);
                string[] s = line.Split('/');
                Format.Add(s[s.Length - 1]);
                Console.WriteLine(i + ". "+line);
            }
        }
    }
}
