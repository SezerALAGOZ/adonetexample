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
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {

      }

      private void btnInsertMovie_Click(object sender, EventArgs e)
      {
         Movies movie = new Movies
         {
            MovieName = txtInsertMovie.Text.Trim(),
            MovieDescription = txtMovieDescription.Text.Trim(),
            MovieDuration = Convert.ToInt32(txtMovieDuration.Text.Trim())
         };

         MoviesController moviesController = new MoviesController();

         bool IsMovieInserted = moviesController.InsertsNewMovie(movie);

         if (IsMovieInserted)
         {
            string successMessage = "Film ekleme başarılı.";
            MessageBox.Show(successMessage);
         }
         else
         {
            string failMessage = "Film ekleme başarısız.";
            MessageBox.Show(failMessage);
         }
      }

      private void btnDeleteMovie_Click(object sender, EventArgs e)
      {
         Movies movie = new Movies
         {
            MovieID = Convert.ToInt32(txtDeleteMovie.Text.Trim())
         };

         MoviesController moviesController = new MoviesController();

         bool IsMovieDeleted = moviesController.DeletesMovie(movie);

         if (IsMovieDeleted)
         {
            string successMessage = "Film silme başarılı.";
            MessageBox.Show(successMessage);
         }
         else
         {
            string failMessage = "Film silme başarısız.";
            MessageBox.Show(failMessage);
         }
      }

      private void btnUpdateMovie_Click(object sender, EventArgs e)
      {
         Movies movie = new Movies
         {
            MovieName = txtUpdateMovieName.Text.Trim(),
            MovieDescription = txtUpdateMovieDescription.Text.Trim(),
            MovieDuration = Convert.ToInt32(txtUpdateMovieDuration.Text.Trim()),
            MovieID = Convert.ToInt32(txtMovieIDToBeUpdated.Text.Trim())
         };

         MoviesController moviesController = new MoviesController();

         bool IsMovieUpdated = moviesController.UpdatesMovie(movie);

         if (IsMovieUpdated)
         {
            string successMessage = "Film güncelleme başarılı.";
            MessageBox.Show(successMessage);
         }
         else
         {
            string failMessage = "Film güncelleme başarısız.";
            MessageBox.Show(failMessage);
         }
      }

      private void btnSelectsMovie_Click(object sender, EventArgs e)
      {
         Movies movie = new Movies()
         {
            MovieID = Convert.ToInt32(txtSelectsMovie.Text.Trim())
         };

         MoviesManagement moviesManagement = new MoviesManagement();

         dtListMovies.DataSource = moviesManagement.ListMovies(movie);
      }

      private void btnNext_Click(object sender, EventArgs e)
      {
         this.Hide();
         Form2 form2 = new Form2();
         form2.Show();
      }
   }
}
