using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrackThread
{
    public class MyThreadClass
    {
        
        public void Thread1() {
            for (int i = 0; i <= 2;i++) {
                Console.WriteLine("Name of Thread: " + Thread.CurrentThread.Name+" Process" +" = "+i);
                Thread.Sleep(500);
            }
            
        }
        public void Thread2() {
            
            for (int i = 0; i <=5 ; i++)
            {
                Console.WriteLine("Name of Thread: " + Thread.CurrentThread.Name + " Process" + " = " + i);
                Thread.Sleep(1500);
            }
        }
    }
    
}
