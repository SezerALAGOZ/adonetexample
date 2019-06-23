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
   public partial class Form3 : Form
   {
      public Form3()
      {
         InitializeComponent();
      }

      private void btnNext_Click(object sender, EventArgs e)
      {
         this.Hide();
         Form4 form4 = new Form4();
         form4.Show();
      }

      private void btnInsertSaloon_Click(object sender, EventArgs e)
      {
         Saloons saloon = new Saloons
         {
            SaloonName = txtInsertSaloon.Text.Trim(),
            SaloonCapacity = Convert.ToInt32(txtInsertSaloonCapacity.Text.Trim())
         };

         SaloonsController saloonsController = new SaloonsController();

         bool IsSaloonInserted = saloonsController.InsertsSaloon(saloon);
         if (IsSaloonInserted)
         {
            string successMessage = "Salon ekleme başarılı.";
            MessageBox.Show(successMessage);
         }
         else
         {
            string failMessage = "Salon ekleme başarısız.";
            MessageBox.Show(failMessage);
         }
      }

      private void btnDeleteSaloon_Click(object sender, EventArgs e)
      {
         Saloons saloon = new Saloons
         {
            SaloonID = Convert.ToInt32(txtDeleteSaloon.Text.Trim())
         };

         SaloonsController saloonsController = new SaloonsController();

         bool IsSaloonDeleted = saloonsController.DeletesSaloon(saloon);
         if (IsSaloonDeleted)
         {
            string successMessage = "Salon silme başarılı.";
            MessageBox.Show(successMessage);
         }
         else
         {
            string failMessage = "Salon silme başarısız.";
            MessageBox.Show(failMessage);
         }
      }

      private void btnUpdateSaloon_Click(object sender, EventArgs e)
      {
         Saloons saloon = new Saloons
         {
            SaloonName = txtUpdateSaloonName.Text.Trim(),
            SaloonCapacity = Convert.ToInt32(txtUpdateSaloonCapacity.Text.Trim()),
            SaloonID = Convert.ToInt32(txtSaloonIDToBeUpdated.Text.Trim())
         };

         SaloonsController saloonsController = new SaloonsController();

         bool IsSaloonUpdated = saloonsController.UpdatesSaloon(saloon);
         if (IsSaloonUpdated)
         {
            string successMessage = "Salon güncelleme başarılı.";
            MessageBox.Show(successMessage);
         }
         else
         {
            string failMessage = "Salon güncelleme başarısız.";
            MessageBox.Show(failMessage);
         }
      }

      private void btnSelectsSaloon_Click(object sender, EventArgs e)
      {
         Saloons saloon = new Saloons
         {
            SaloonID = Convert.ToInt32(txtSelectsSaloon.Text.Trim())
         };

         SaloonsManagement saloonsManagement = new SaloonsManagement();

         dtListSaloons.DataSource = saloonsManagement.SelectSaloon(saloon);
      }
   }
}
