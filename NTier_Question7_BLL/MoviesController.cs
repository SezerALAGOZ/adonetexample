using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTier_Question7_DAL;
using NTier_Question7_Entities;

namespace NTier_Question7_BLL
{
    public class MoviesController
    {
      MoviesManagement moviesManagement;

      public MoviesController()
      {
         moviesManagement = new MoviesManagement();
      }

      public bool InsertsNewMovie(Movies movie)
      {
         if (string.IsNullOrWhiteSpace(movie.MovieName))
         {
            return false;
         }

         if (movie.MovieName.Length > 50)
         {
            return false;
         }

         if (movie.MovieDuration <= 0)
         {
            return false;
         }

         return moviesManagement.InsertNewMovie(movie);

      }

      public bool DeletesMovie(Movies movie)
      {
         if (movie.MovieID <= 0)
         {
            return false;
         }

         return moviesManagement.DeleteMovies(movie);
      }

      public bool UpdatesMovie(Movies movie)
      {
         if (movie.MovieID <= 0)
         {
            return false;
         }

         if (string.IsNullOrWhiteSpace(movie.MovieName))
         {
            return false;
         }

         if (movie.MovieName.Length > 50)
         {
            return false;
         }

         if (movie.MovieDuration <= 0)
         {
            return false;
         }

         return moviesManagement.UpdateMovies(movie);
      }

   }
}
