using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NTier_Question7_BLL;
using NTier_Question7_DAL;
using NTier_Question7_Entities;

namespace NTier_Question7
{
   public partial class Form2 : Form
   {
      public Form2()
      {
         InitializeComponent();
      }

      private void btnInsertCategory_Click(object sender, EventArgs e)
      {
         Categories category = new Categories
         {
            CategoryName = txtInsertCategory.Text.Trim()
         };

         CategoriesController categoriesController = new CategoriesController();

         bool IsCategoryInserted = categoriesController.InsertsNewCategory(category);

         if (IsCategoryInserted)
         {
            string successMessage = "Kategori ekleme başarılı.";
            MessageBox.Show(successMessage);
         }
         else
         {
            string failMessage = "Kategori ekleme başarısız.";
            MessageBox.Show(failMessage);
         }
      }

      private void btnDeleteCategory_Click(object sender, EventArgs e)
      {
         Categories category = new Categories
         {
            CategoryID = Convert.ToInt32(txtDeleteCategory.Text.Trim())
         };

         CategoriesController categoriesController = new CategoriesController();

         bool IsCategoryDeleted = categoriesController.DeletesCategory(category);

         if (IsCategoryDeleted)
         {
            string successMessage = "Kategori silme başarılı.";
            MessageBox.Show(successMessage);
         }
         else
         {
            string failMessage = "Kategori silme başarısız.";
            MessageBox.Show(failMessage);
         }

      }

      private void btnUpdateCategory_Click(object sender, EventArgs e)
      {
         Categories category = new Categories
         {
            CategoryName = txtUpdateCategoryName.Text.Trim(),
            CategoryID = Convert.ToInt32(txtCategoryIDToBeUpdated.Text.Trim())
         };

         CategoriesController categoriesController = new CategoriesController();

         bool IsCategoryUpdated = categoriesController.UpdatesCategory(category);

         if (IsCategoryUpdated)
         {
            string successMessage = "Kategori güncelleme başarılı.";
            MessageBox.Show(successMessage);
         }
         else
         {
            string failMessage = "Kategori güncelleme başarısız.";
            MessageBox.Show(failMessage);
         }
      }

      private void btnSelectsCategory_Click(object sender, EventArgs e)
      {
         Categories category = new Categories
         {
            CategoryID = Convert.ToInt32(txtSelectsCategory.Text.Trim())
         };

         CategoriesManagement categoriesManagement = new CategoriesManagement();

         dtListCategories.DataSource = categoriesManagement.SelectCategory(category);
      }

      private void btnNext_Click(object sender, EventArgs e)
      {
         this.Hide();
         Form3 form3 = new Form3();
         form3.Show();
      }
   }
}
