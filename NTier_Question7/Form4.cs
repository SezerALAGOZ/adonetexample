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
   public partial class Form4 : Form
   {
      public Form4()
      {
         InitializeComponent();
      }

      private void btnNext_Click(object sender, EventArgs e)
      {
         this.Hide();
         Form5 form5 = new Form5();
         form5.Show();
      }

      private void btnInsertWeek_Click(object sender, EventArgs e)
      {
         DisplayWeeks displayWeek = new DisplayWeeks
         {
            WeekName = txtInsertWeek.Text.Trim()
         };

         DisplayWeeksController displayWeeksController = new DisplayWeeksController();

         bool IsWeekInserted = displayWeeksController.InsertsDisplayWeeks(displayWeek);

         if (IsWeekInserted)
         {
            string successMessage = "Hafta ekleme başarılı.";
            MessageBox.Show(successMessage);
         }
         else
         {
            string failMessage = "Hafta ekleme başarısız.";
            MessageBox.Show(failMessage);
         }
      }

      private void btnDeleteWeek_Click(object sender, EventArgs e)
      {
         DisplayWeeks displayWeek = new DisplayWeeks
         {
            DisplayWeeksID = Convert.ToInt32(txtDeleteWeek.Text.Trim())
         };

         DisplayWeeksController displayWeeksController = new DisplayWeeksController();

         bool IsWeekDeleted = displayWeeksController.DeletesDisplayWeeks(displayWeek);

         if (IsWeekDeleted)
         {
            string successMessage = "Hafta silme başarılı.";
            MessageBox.Show(successMessage);
         }
         else
         {
            string failMessage = "Hafta silme başarısız.";
            MessageBox.Show(failMessage);
         }
      }

      private void btnUpdateWeek_Click(object sender, EventArgs e)
      {
         DisplayWeeks displayWeek = new DisplayWeeks
         {
            WeekName = txtUpdateWeekName.Text.Trim(),
            DisplayWeeksID = Convert.ToInt32(txtDisplayWeeksIDToBeUpdated.Text.Trim())
         };

         DisplayWeeksController displayWeeksController = new DisplayWeeksController();

         bool IsWeekUpdated = displayWeeksController.UpdatesDisplayWeeks(displayWeek);

         if (IsWeekUpdated)
         {
            string successMessage = "Hafta güncelleme başarılı.";
            MessageBox.Show(successMessage);
         }
         else
         {
            string failMessage = "Hafta güncelleme başarısız.";
            MessageBox.Show(failMessage);
         }
      }

      private void btnSelectsWeek_Click(object sender, EventArgs e)
      {
         DisplayWeeks displayWeek = new DisplayWeeks
         {
            DisplayWeeksID = Convert.ToInt32(txtSelectsWeek.Text.Trim())
         };

         DisplayWeeksManagement displayWeeksManagement = new DisplayWeeksManagement();
         dtListDisplayWeeks.DataSource = displayWeeksManagement.SelectDisplayWeeks(displayWeek);
      }
   }
}
