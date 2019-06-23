using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTier_Question7_DAL;
using NTier_Question7_Entities;

namespace NTier_Question7_BLL
{
   public class SaloonsController
   {
      SaloonsManagement saloonsManagement;
      public SaloonsController()
      {
         saloonsManagement = new SaloonsManagement();
      }

      public bool InsertsSaloon(Saloons saloon)
      {
         if (string.IsNullOrWhiteSpace(saloon.SaloonName))
         {
            return false;
         }

         if (saloon.SaloonName.Length > 20)
         {
            return false;
         }

         if (saloon.SaloonCapacity <= 0)
         {
            return false;
         }

         return saloonsManagement.InsertSaloon(saloon);
      }

      public bool DeletesSaloon(Saloons saloon)
      {

         if (saloon.SaloonID <= 0)
         {
            return false;
         }

         return saloonsManagement.DeleteSaloon(saloon);
      }

      public bool UpdatesSaloon(Saloons saloon)
      {
         if (string.IsNullOrWhiteSpace(saloon.SaloonName))
         {
            return false;
         }

         if (saloon.SaloonName.Length > 20)
         {
            return false;
         }

         if (saloon.SaloonCapacity <= 0)
         {
            return false;
         }

         if (saloon.SaloonID <= 0)
         {
            return false;
         }

         return saloonsManagement.UpdateSaloon(saloon);
      }

   }
}
