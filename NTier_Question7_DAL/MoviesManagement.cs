using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using NTier_Question7_Entities;
using System.Data;

namespace NTier_Question7_DAL
{
    public class MoviesManagement
    {
      string connectionPath;
      SqlConnection sqlConnection;
      SqlCommand sqlCommand;

      public MoviesManagement()
      {
         connectionPath = ConfigurationManager.ConnectionStrings["connectionToDBQuestion7"].ConnectionString;
         sqlConnection = new SqlConnection();
         sqlCommand = new SqlCommand();
      }

      public bool InsertNewMovie(Movies movie)
      {
         sqlCommand.Connection = sqlConnection;
         sqlCommand.CommandType = CommandType.StoredProcedure;
         sqlCommand.CommandText = "SP_AddsMovie";
         sqlCommand.Parameters.AddWithValue("@movieName", movie.MovieName);
         sqlCommand.Parameters.AddWithValue("@movieDescription", movie.MovieDescription);
         sqlCommand.Parameters.AddWithValue("@movieDuration", movie.MovieDuration);

         try
         {
            if (sqlConnection.State != ConnectionState.Open)
            {
               sqlConnection.ConnectionString = connectionPath;
               sqlConnection.Open();
            }
            return sqlCommand.ExecuteNonQuery() > 0;
         }
         catch (Exception ex)
         {
            var errorMessage = $"An error has occurred during insertion: {ex}";
            return false;
         }
         finally
         {
            sqlConnection.Close();
         }
      }

      public bool DeleteMovies(Movies movie)
      {
         sqlCommand.Connection = sqlConnection;
         sqlCommand.CommandType = CommandType.StoredProcedure;
         sqlCommand.CommandText = "SP_DeletesMovie";
         sqlCommand.Parameters.AddWithValue("@movieID", movie.MovieID);

         try
         {
            if (sqlConnection.State != ConnectionState.Open)
            {
               sqlConnection.ConnectionString = connectionPath;
               sqlConnection.Open();
            }
            return sqlCommand.ExecuteNonQuery() > 0;
         }
         catch (Exception ex)
         {
            var errorMessage = $"An error has occurred during deletion: {ex}";
            return false;
         }
         finally
         {
            sqlConnection.Close();
         }
      }

      public bool UpdateMovies(Movies movie)
      {
         sqlCommand.Connection = sqlConnection;
         sqlCommand.CommandType = CommandType.StoredProcedure;
         sqlCommand.CommandText = "SP_UpdatesMovie";
         sqlCommand.Parameters.AddWithValue("@movieName", movie.MovieName);
         sqlCommand.Parameters.AddWithValue("@movieDescription", movie.MovieDescription);
         sqlCommand.Parameters.AddWithValue("@movieDuration", movie.MovieDuration);
         sqlCommand.Parameters.AddWithValue("@movieID", movie.MovieID);

         try
         {
            if (sqlConnection.State != ConnectionState.Open)
            {
               sqlConnection.ConnectionString = connectionPath;
               sqlConnection.Open();
            }
            return sqlCommand.ExecuteNonQuery() > 0;
         }
         catch (Exception ex)
         {
            var errorMessage = $"An error has occurred during update: {ex}";
            return false;
         }
         finally
         {
            sqlConnection.Close();
         }
      }

      public object ListMovies(Movies movie)
      {
         sqlCommand.Connection = sqlConnection;
         sqlCommand.CommandType = CommandType.StoredProcedure;
         sqlCommand.CommandText = "SP_SelectsMovie";
         sqlCommand.Parameters.AddWithValue("@movieID", movie.MovieID);

         try
         {
            if (sqlConnection.State != ConnectionState.Open)
            {
               sqlConnection.ConnectionString = connectionPath;
               sqlConnection.Open();
            }

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dtSelectedMovie = new DataTable();
            sqlDataAdapter.Fill(dtSelectedMovie);

            return dtSelectedMovie;
         }
         catch (Exception ex)
         {
            var errorMessage = $"An error has occurred during selection: {ex}";
            return false;
         }
         finally
         {
            sqlConnection.Close();
         }
      }
   }
}
