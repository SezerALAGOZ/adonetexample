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
   public class SaloonsManagement
   {
      string connectionPath;
      SqlConnection sqlConnection;
      SqlCommand sqlCommand;

      public SaloonsManagement()
      {
         connectionPath = ConfigurationManager.ConnectionStrings["connectionToDBQuestion7"].ConnectionString;
         sqlConnection = new SqlConnection();
         sqlCommand = new SqlCommand();
      }

      public bool InsertSaloon(Saloons saloon)
      {
         sqlCommand.Connection = sqlConnection;
         sqlCommand.CommandType = CommandType.StoredProcedure;
         sqlCommand.CommandText = "SP_InsertsSaloons";
         sqlCommand.Parameters.AddWithValue("@saloonName", saloon.SaloonName);
         sqlCommand.Parameters.AddWithValue("@saloonCapacity", saloon.SaloonCapacity);

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

      public bool DeleteSaloon(Saloons saloon)
      {
         sqlCommand.Connection = sqlConnection;
         sqlCommand.CommandType = CommandType.StoredProcedure;
         sqlCommand.CommandText = "SP_DeletesSaloons";
         sqlCommand.Parameters.AddWithValue("@saloonID", saloon.SaloonID);

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

      public bool UpdateSaloon(Saloons saloon)
      {
         sqlCommand.Connection = sqlConnection;
         sqlCommand.CommandType = CommandType.StoredProcedure;
         sqlCommand.CommandText = "SP_UpdatesSaloons";
         sqlCommand.Parameters.AddWithValue("@saloonName", saloon.SaloonName);
         sqlCommand.Parameters.AddWithValue("@saloonCapacity", saloon.SaloonCapacity);
         sqlCommand.Parameters.AddWithValue("@saloonID", saloon.SaloonID);

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

      public object SelectSaloon(Saloons saloon)
      {
         sqlCommand.Connection = sqlConnection;
         sqlCommand.CommandType = CommandType.StoredProcedure;
         sqlCommand.CommandText = "SP_SelectsSaloons";
         sqlCommand.Parameters.AddWithValue("@saloonID", saloon.SaloonID);

         try
         {
            if (sqlConnection.State != ConnectionState.Open)
            {
               sqlConnection.ConnectionString = connectionPath;
               sqlConnection.Open();
            }

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dtSelectSaloon = new DataTable();
            sqlDataAdapter.Fill(dtSelectSaloon);

            return dtSelectSaloon;
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
