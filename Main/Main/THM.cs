using System;
using System.IO;
using System.Net;
using System.Text;
using System.Linq;
using System.Threading;
using Main;
 class THM
{

    private static THM instance = new THM();
    public static THM Instance
    {
        get { return instance; }
        set { }
    }

    public void Thread(string add,string format)
    {
        DLM DL = DLM.Instance;
        Thread DownThread;
        ThreadStart startDownLoad = new ThreadStart(delegate () { DL.Download(add,format);});
        DownThread = new Thread(startDownLoad);
        DownThread.Start();
       
    }
    public void First4()
    {
        DLM DL  = new DLM();
        Thread DownThread;
        for (int i = 0; i <= 3; i++)
        {
            ThreadStart startDownLoad = new ThreadStart(delegate () { DL.Download(FRM.Instance.Address[i], FRM.Instance.Format[i]); });
            DownThread = new Thread(startDownLoad);
            DownThread.Start();
        }

    }

 }
