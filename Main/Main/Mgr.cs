using System;
using System.IO;
using System.Net;
using System.Text;
using System.Linq;
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
          
            TxTMgr.Instance.Start();
            this.StartConfirm();
            TxTMgr.Instance.ConfirmDownLoad();
            this.DownLoadConfirm();
            Console.ReadLine();
        }
        public void StartConfirm()
        {
            if (TxTMgr.Instance.StartFlag == "1")
            {
                FRM.Instance.FileRead();
            }
            else
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }

        public void DownLoadConfirm()
        {
            if (TxTMgr.Instance.ConfirmFlag== "1")
            {
                THM FirstDo = new THM();
                FirstDo.First4();
            }
            else
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }
    }
}
