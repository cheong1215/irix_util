using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlarm
{
   public class ArticleInfo
   {
      public string Title { get; set; }
      public int ID { get; set; }
      public string Url { get; set; }
      public int TailCount { get; set; }

      public ArticleInfo(string title, int id, string url, int tailCount)
      {
         Title = title;
         ID = id;
         Url = url;
         TailCount = tailCount;
      } 
   }
}
