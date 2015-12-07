using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Main
{
    class Mgr
    {
        private static Mgr instance = new Mgr();
        public static Mgr Instance {
            get { return instance; }


            set { } }
       
        public void Bus()
        {
            THM FirstDo = new THM();

           FRM.Instance.FileRead(); 
            Thread.Sleep(2000);
            FirstDo.First4();
            Console.ReadLine();
        }
    }
}
