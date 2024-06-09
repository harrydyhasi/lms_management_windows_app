using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataProvider
    {
        private static DataProvider instance;
        private string connectString = "Data Source=ADMIN\\THSQLSERVER;Initial Catalog=TalemyLMS5;Integrated Security=True";

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return DataProvider.instance;
            }

            private set
            {
                DataProvider.instance = value;
            }
        }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] lstPara = query.Split(' ');
                    int i = 0;  
                    foreach(string item in lstPara)
                    {
                        if(item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public int MyExecuteNonQuery(ref string error, string query)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                try
                {                
                    cmd.CommandType = CommandType.Text;
                    data = cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    error = ex.Message;
                }
                finally
                {
                    connection.Close();
                }
            }
            return data;
        }

        public int ExecuteNonQuery(ref string error, string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                try
                {
                    if (parameter != null)
                    {
                        string[] lstPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in lstPara)
                        {
                            if (item.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    
                    data = cmd.ExecuteNonQuery();
                }
                catch(SqlException ex)
                {
                    error = ex.Message;
                }
                finally
                {
                    connection.Close();
                }
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] lstPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in lstPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                connection.Close();
            }
            return data;
        }


    }
}
