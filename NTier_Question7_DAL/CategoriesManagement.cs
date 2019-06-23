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
   public class CategoriesManagement
   {
      string connectionPath;
      SqlConnection sqlConnection;
      SqlCommand sqlCommand;

      public CategoriesManagement()
      {
         connectionPath = ConfigurationManager.ConnectionStrings["connectionToDBQuestion7"].ConnectionString;
         sqlConnection = new SqlConnection();
         sqlCommand = new SqlCommand();
      }

      public bool InsertCategory(Categories category)
      {
         sqlCommand.Connection = sqlConnection;
         sqlCommand.CommandType = CommandType.StoredProcedure;
         sqlCommand.CommandText = "SP_InsertsCategory";
         sqlCommand.Parameters.AddWithValue("@categoryName", category.CategoryName);

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

      public bool DeleteCategory(Categories category)
      {
         sqlCommand.Connection = sqlConnection;
         sqlCommand.CommandType = CommandType.StoredProcedure;
         sqlCommand.CommandText = "SP_DeletesCategory";
         sqlCommand.Parameters.AddWithValue("@categoryID", category.CategoryID);

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

      public bool UpdateCategory(Categories category)
      {
         sqlCommand.Connection = sqlConnection;
         sqlCommand.CommandType = CommandType.StoredProcedure;
         sqlCommand.CommandText = "SP_UpdatesCategory";
         sqlCommand.Parameters.AddWithValue("@categoryName", category.CategoryName);
         sqlCommand.Parameters.AddWithValue("@categoryID", category.CategoryID);

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

      public object SelectCategory(Categories category)
      {
         sqlCommand.Connection = sqlConnection;
         sqlCommand.CommandType = CommandType.StoredProcedure;
         sqlCommand.CommandText = "SP_SelectsCategory";
         sqlCommand.Parameters.AddWithValue("@categoryID", category.CategoryID);

         try
         {
            if (sqlConnection.State != ConnectionState.Open)
            {
               sqlConnection.ConnectionString = connectionPath;
               sqlConnection.Open();
            }
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dtSelectCategory = new DataTable();
            sqlDataAdapter.Fill(dtSelectCategory);
            return dtSelectCategory;
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
