using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier_Question7_Entities
{
   public class DisplayWeeks
   {
      public int? DisplayWeeksID { get; set; }

      public string WeekName { get; set; }
      public DateTime? WeekFirstDay { get; set; }

      public DateTime? WeekLastDay { get; set; }
   }
}
