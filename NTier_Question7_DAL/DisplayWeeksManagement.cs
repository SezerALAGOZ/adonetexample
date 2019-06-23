using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTier_Question7_Entities;

namespace NTier_Question7_DAL
{
   public class DisplayWeeksManagement
   {
      string connectionPath;
      SqlConnection sqlConnection;
      SqlCommand sqlCommand;

      public DisplayWeeksManagement()
      {
         connectionPath = ConfigurationManager.ConnectionStrings["connectionToDBQuestion7"].ConnectionString;
         sqlConnection = new SqlConnection(connectionPath);
         sqlCommand = new SqlCommand();
      }

      public bool InsertDisplayWeeks(DisplayWeeks displayWeek)
      {
         sqlCommand.Connection = sqlConnection;
         sqlCommand.CommandType = CommandType.StoredProcedure;
         sqlCommand.CommandText = "SP_InsertsDisplayWeek";
         sqlCommand.Parameters.AddWithValue("@weekName", displayWeek.WeekName);

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

      public bool DeleteDisplayWeeks(DisplayWeeks diplayWeek)
      {
         sqlCommand.Connection = sqlConnection;
         sqlCommand.CommandType = CommandType.StoredProcedure;
         sqlCommand.CommandText = "SP_DeletesDisplayWeek";
         sqlCommand.Parameters.AddWithValue("@displayWeeksID", diplayWeek.DisplayWeeksID);

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

      public bool UpdateDisplayWeeks(DisplayWeeks displayWeek)
      {
         sqlCommand.Connection = sqlConnection;
         sqlCommand.CommandType = CommandType.StoredProcedure;
         sqlCommand.CommandText = "SP_UpdatesDisplayWeek";
         sqlCommand.Parameters.AddWithValue("@weekName", displayWeek.WeekName);
         sqlCommand.Parameters.AddWithValue("@displayWeeksID", displayWeek.DisplayWeeksID);

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

      public object SelectDisplayWeeks(DisplayWeeks displayWeek)
      {
         sqlCommand.Connection = sqlConnection;
         sqlCommand.CommandType = CommandType.StoredProcedure;
         sqlCommand.CommandText = "SP_SelectsDisplayWeek";
         sqlCommand.Parameters.AddWithValue("@displayWeeksID", displayWeek.DisplayWeeksID);

         try
         {
            if (sqlConnection.State != ConnectionState.Open)
            {
               sqlConnection.ConnectionString = connectionPath;
               sqlConnection.Open();
            }

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dtSelectDisplayWeeks = new DataTable();
            sqlDataAdapter.Fill(dtSelectDisplayWeeks);
            return dtSelectDisplayWeeks;
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
   }
}
