using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackThread
{
    public partial class frmTrackThread : Form
    {
        Thread threadA,threadB,threadC,threadD;
        MyThreadClass myThread;
        public frmTrackThread()
        {
            InitializeComponent();
            myThread = new MyThreadClass();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ThreadStart thread1 = new ThreadStart(myThread.Thread1);
            ThreadStart thread2 = new ThreadStart(myThread.Thread2);

            threadA = new Thread(thread1);
            threadB = new Thread(thread2);
            threadC = new Thread(thread1);
            threadD = new Thread(thread2);

            threadA.Name = "Thread A";
            threadB.Name = "Thread B";
            threadC.Name = "Thread C";
            threadD.Name = "Thread D";

            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;
            Console.WriteLine("-Thread Starts-");
            lblIndicator.Text = "-Thread Starts-";
            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();
            Console.WriteLine("-End of Thread-");
            lblIndicator.Text = "-End of Thread-";



        }
    }
}
