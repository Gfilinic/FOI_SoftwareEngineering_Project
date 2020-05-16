using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class DataBaseI
    {
        private static DataBaseI instance;
        public static DataBaseI Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataBaseI();
                }
                return instance;
            }
        }


        private string connectionString = @"Data Source =31.147.204.119\PISERVER,1433; Initial Catalog =SE20E02_DB; User=SE20E02_User; Password=jq=}+4l1";
        private SqlConnection Connection { get; set; }

        public void Connect()
        {
            Connection = new SqlConnection(connectionString);
            Connection.Open();
        }

        public void Disconnect()
        {
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
        }

        

        public IDataReader GetDataReader(string sqlInquiry)
        {
            SqlCommand command = new SqlCommand(sqlInquiry, Connection);
            return command.ExecuteReader();
        }

        public object GetValue(string sqlInquiry)
        {
            SqlCommand command = new SqlCommand(sqlInquiry, Connection);
            return command.ExecuteScalar();
        }

        public int ExecuteCommand(string sqlInquiry)
        {
            SqlCommand command = new SqlCommand(sqlInquiry, Connection);
            return command.ExecuteNonQuery();
        }

        /// <summary>Use this method to add images.
        /// You must use @image when adding SQLcommand.</summary>
        ///
        public int ExecuteCommandImageParametar(string sqlInquiry, byte[] image)
        {
            SqlCommand command = new SqlCommand(sqlInquiry, Connection);
            command.Parameters.Add(new SqlParameter("@image", image));
            return command.ExecuteNonQuery();
        }
    }
}
