using System;
using System.IO;
using System.Net;
using System.Text;
using System.Linq;
using System.Threading;
using System.ComponentModel;

namespace Main
{
    class DLM
    {
        private static DLM instance = new DLM();
        public static DLM Instance
        {
            get { return instance; }
            set { }
        }
        static int i = 0;
        public void Download(string a, string b)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFileAsync(new Uri(a), @"D:\Users\seven\Desktop\" + b);
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DlMore);
            
            i++;
        }
        public void DlMore(object temp, AsyncCompletedEventArgs e)
        {
            Console.WriteLine("我下载结束");
            if (i>FRM.Instance.i-1)
            {
                return;
            }
            else
            {
                THM.Instance.Thread(FRM.Instance.Address[i], FRM.Instance.Format[i]);
            }
        }
    }
}
