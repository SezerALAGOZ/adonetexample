using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTier_Question7_DAL;
using NTier_Question7_Entities;

namespace NTier_Question7_BLL
{
   public class DisplayWeeksController
   {
      DisplayWeeksManagement displayWeeksManagement;
      public DisplayWeeksController()
      {
         displayWeeksManagement = new DisplayWeeksManagement();
      }

      public bool InsertsDisplayWeeks(DisplayWeeks displayWeek)
      {
         if (string.IsNullOrWhiteSpace(displayWeek.WeekName))
         {
            return false;
         }

         if (displayWeek.WeekName.Length > 20)
         {
            return false;
         }

         return displayWeeksManagement.InsertDisplayWeeks(displayWeek);
      }

      public bool DeletesDisplayWeeks(DisplayWeeks displayWeek)
      {
         if (displayWeek.DisplayWeeksID <= 0)
         {
            return false;
         }

         return displayWeeksManagement.DeleteDisplayWeeks(displayWeek);
      }

      public bool UpdatesDisplayWeeks(DisplayWeeks displayWeek)
      {
         if (string.IsNullOrWhiteSpace(displayWeek.WeekName))
         {
            return false;
         }

         if (displayWeek.WeekName.Length > 20)
         {
            return false;
         }

         if (displayWeek.DisplayWeeksID <= 0)
         {
            return false;
         }

         return displayWeeksManagement.UpdateDisplayWeeks(displayWeek);

      }
   }
}
