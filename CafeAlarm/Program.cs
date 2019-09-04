using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CafeAlarm
{
   static class Program
   {
      /// <summary>
      /// 해당 애플리케이션의 주 진입점입니다.
      /// </summary>
      [STAThread]
      static void Main()
      {
         string mutexName = "CafeAlarm";
         Mutex mtx = new Mutex(true, mutexName);

         TimeSpan tsWait = new TimeSpan(0, 0, 1);
         bool success = mtx.WaitOne(tsWait);

         // 실패하면 프로그램 종료  
         if (!success)
         {
            return;
         }

         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new FormMain());
      }
   }
}
