using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTier_Question7_DAL;
using NTier_Question7_Entities;

namespace NTier_Question7_BLL
{
   public class CategoriesController
   {
      CategoriesManagement categoriesManagement;

      public CategoriesController()
      {
         categoriesManagement = new CategoriesManagement();
      }

      public bool InsertsNewCategory(Categories category)
      {
         if (string.IsNullOrWhiteSpace(category.CategoryName))
         {
            return false;
         }

         if (category.CategoryName.Length > 50)
         {
            return false;
         }

         return categoriesManagement.InsertCategory(category);
      }

      public bool DeletesCategory(Categories category)
      {
         if (category.CategoryID < 0)
         {
            return false;
         }

         return categoriesManagement.DeleteCategory(category);
      }

      public bool UpdatesCategory(Categories category)
      {
         if (string.IsNullOrWhiteSpace(category.CategoryName))
         {
            return false;
         }

         if (category.CategoryName.Length > 50)
         {
            return false;
         }

         if (category.CategoryID <= 0)
         {
            return false;
         }

         return categoriesManagement.UpdateCategory(category);
      }

   }
}
