using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using iCSHD.Models;

namespace iCSHD.Helpers
{
    public class SQLHelpers
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["SDCasesTEST"].ConnectionString;
        public static CxProfile GetCustomerInfo(Guid CustomerId)
        {
            CxProfile cxProfile = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand("[dbo].[GetCustomerInfo]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@CxID", CustomerId));
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cxProfile = new CxProfile(reader.GetGuid(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetString(4), reader.GetString(5), reader.GetDouble(6));
                    }

                    return cxProfile;

                }

                reader.Close();
                command.Dispose();
            }

            return cxProfile;

        }

        public static EngineerProfile GetEnginenerInfo(Guid EngineerId)
        {
            EngineerProfile engprofile = null;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand("[dbo].[GetEngineerInfo]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@EngID", EngineerId));
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        engprofile = new EngineerProfile(reader.GetGuid(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                    }

                    reader.Close();
                    command.Dispose();
                    return engprofile;

                }

                reader.Close();
                command.Dispose();
            }

            return engprofile;

        }


        public static Case GetCaseByCxID(Guid CxID)
        {

            Case cxcase = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand("[dbo].[GetCaseByCxID]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@cxID", CxID));
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cxcase = new Case(reader.GetGuid(0), reader.GetInt64(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetString(5), reader.GetFloat(6), reader.GetFloat(7), reader.GetInt32(8), reader.GetInt32(9), reader.GetInt32(10), reader.GetBoolean(11));
                    }

                    reader.Close();
                    command.Dispose();
                    return cxcase;

                }

                reader.Close();
                command.Dispose();
             
            }

            return cxcase;


        }

        public List<CxProfile> GetCxInfoByEngAlias(String EngAlias)
        {

            List<CxProfile> cxProfiles = new List<CxProfile>();

           
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    SqlCommand command = new SqlCommand("[dbo].[GetFullCustomerInfo]", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@EngAlias", EngAlias));
                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    command.Connection.Open();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
           
                    int rowcount = dt.Rows.Count;

                    while (reader.ReadAsync().Result)

                        {
                            foreach (DataRow row in dt.Rows)
                            { 
                            

                                cxProfiles.Add(GetCustomerInfo((Guid)row["customerid"]));


                            }

                            reader.Close();
                            command.Dispose();

                            return cxProfiles;

                        }


                        reader.Close();
                        command.Dispose();
                        return cxProfiles;


                    }


                    reader.Close();
                    command.Dispose();
                }


            
    


            return cxProfiles;
        }



        public CxProfile GetCxInfoByEngAliasView(String EngAlias)
        {

            CxProfile cxProfile = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand("[dbo].[GetCxInfoByEngAlias]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@EngAlias", EngAlias));
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.ReadAsync().Result)
                    {
                        cxProfile = new CxProfile(reader.GetString(0), reader.GetDouble(1), reader.GetString(2), reader.GetString(3));


                        reader.Close();
                        command.Dispose();
                        return cxProfile;

                    }
                }

                reader.Close();
                command.Dispose();

            }

            return cxProfile;
        }

    }
}