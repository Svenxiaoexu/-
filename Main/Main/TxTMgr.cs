using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class TxTMgr
    {
        private static TxTMgr instance = new TxTMgr();
        public static TxTMgr Instance
        {
            get { return instance; }
            set { }
        }
        public string StartFlag;
        public string ConfirmFlag;
        public void Start()
        {

            Console.WriteLine("            ***************************************************\r\n");
            Console.WriteLine("            *                   欢迎来到下载器                *\r\n");
            Console.WriteLine("            *                   请输入你的选项                *\r\n");           
            Console.WriteLine("            *                                                 *\r\n");
            Console.WriteLine("            *             1.下载桌面TXT中地址中的文件         *\r\n");
            Console.WriteLine("            *             2.退出                              *\r\n");
            Console.WriteLine("            ***************************************************\r\n");
            StartFlag = Console.ReadLine();
        }

        public void ConfirmDownLoad()
        {
            Console.WriteLine("            ***************************************************");
            Console.WriteLine("            *                 以上是你要下载的文件            *");
            Console.WriteLine("            *                     是否确认下载                *");
            Console.WriteLine("            *                     1.确定                      *");
            Console.WriteLine("            *                     2.退出                      *");
            Console.WriteLine("            ***************************************************");
            ConfirmFlag = Console.ReadLine();

        }
        public void StartDownLoad()
        {
            Console.WriteLine("            ***************************************************");
            Console.WriteLine("            *                     开始下载文件                *");
            Console.WriteLine("            ***************************************************");
        }
    }
}
