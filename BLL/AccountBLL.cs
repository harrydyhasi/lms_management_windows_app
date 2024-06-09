using System.Data;
using System.Data.SqlClient;
using BLL.Models;
using DAL;
using BLL;
using System.Data.SqlTypes;
using System.Net;
using System.Numerics;
using System.Xml.Linq;
using System.Globalization;

namespace BLL
{
    public class AccountBLL : BLLInterface<Account>
    {
        private static AccountBLL instance;
        string err;
        public static AccountBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountBLL();
                }
                return AccountBLL.instance;
            }

            private set
            {
                AccountBLL.instance = value;
            }
        }
        public AccountBLL()
        {
            
        }
        public bool isLogin(string username, string password)
        {
            string query = "select dbo.fn_LoginByUsernamePassword('" + username + "', '" + password + "')";
            bool result = (bool)DataProvider.Instance.ExecuteScalar(query); 
            return result; 
        }

        public bool changePassword(string username, string newPassword, ref string err)
        {
            int result = 0;
            try
            {
                string query = "EXEC dbo.proc_Change_Password @username , @newPassword";
                result = DataProvider.Instance.ExecuteNonQuery(ref err, query, new object[] { username, newPassword });
            }

            catch (SqlException ex)
            {
                err = ex.Message;
            }

            return result > 0;
        }
        public string GetTypeByUsername(string username)
        {
            return (string)DataProvider.Instance.ExecuteScalar("select dbo.fn_TypeAccount('" + username + "')");         
        }
        public string ResetPassword()
        {
            return (string)DataProvider.Instance.ExecuteScalar("exec dbo.proc_Create_GenRandomPassword");
        }

        public List<Account> getAll()
        {
            List<Account> list = new List<Account>();
            DataTable T = DataProvider.Instance.ExecuteQuery("select * from account_list");
            foreach (DataRow row in T.Rows)
            {
                list.Add(new Account(row));
            }
            return list;
        }

        public AccountInfor GetAccountInfor(string username)
        {

            DataTable T = DataProvider.Instance.ExecuteQuery("EXEC dbo.proc_GetAccountInforById @username", new object[] { username });
            foreach (DataRow r in T.Rows)
            {
                return new AccountInfor(r);
            }
            return new AccountInfor();
        }

        public DataTable getTable()
        {

            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery("select * from AccountInfor_list");
            return dt;
        }

        public int add(Account t, ref string err)
        {
            return 0;
        }

        public int AddAccount(Account t1,AccountInfor t2, ref string err)
        {

            Thread.CurrentThread.CurrentCulture = new CultureInfo("ja-JP");
            int result = 0;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(ref err, "EXEC dbo.proc_AddAccount @username , @password , @type , @avatar_path , @f_name , @m_name , @l_name , @email , @phone , @date_of_birth , @address", new object[] { t1.Username, t1.Password, t1.Type, t2.AvatarPath, t2.FName, t2.MName, t2.LName, t2.Email, t2.PhoneNumb, t2.DateOfBirth.ToShortDateString(), t2.Address });
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return result;
        }

        public DataTable SearchAccountByUsername(string username, string type)
        {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(String.Format("EXEC dbo.proc_SearchAccountByUsername '{0}', '{1}' ",username, type));
            return dt;
        }
        public DataTable SearchAccountByName(string name, string type)
        {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(String.Format("EXEC dbo.proc_SearchAccountByName '{0}', '{1}' ", name, type ));
            return dt;
        }

        public int delete(Account t, ref string err)
        {
            int result = 0;
            try
            {
                result = DataProvider.Instance.MyExecuteNonQuery(ref err, String.Format("EXEC dbo.proc_DeleteAccount '{0}', '{1}'", t.Username, DateTime.Now));

            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return result;
        }

        public int deleteAccount(string username, ref string err)
        {
            int result = 0;
            try
            {
                result = DataProvider.Instance.MyExecuteNonQuery(ref err, String.Format("EXEC dbo.proc_DeleteAccount '{0}', '{1}'", username, DateTime.ParseExact(DateTime.Now.ToString("yyyy-mm-dd"), "yyyy-mm-dd",
                                   CultureInfo.InvariantCulture)));
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return result;
        }
        public int UpdateAccountInfor(Account t1, AccountInfor t2, ref string err)
        {
            int result = 0;
            try
            {            
                result = DataProvider.Instance.ExecuteNonQuery(ref err, "EXEC dbo.proc_Update_Account @username , @password , @avatar_path , @f_name , @m_name , @l_name , @email , @phone , @date_of_birth , @address", new object[] { t1.Username, t1.Password, t2.AvatarPath, t2.FName, t2.MName, t2.LName, t2.Email, t2.PhoneNumb, t2.DateOfBirth, t2.Address });
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return result;
        }

        public int update(Account t, ref string err)
        {
            return 0;
        }

        public Account getById(string id)
        {
            DataTable T = DataProvider.Instance.ExecuteQuery("EXEC dbo.proc_GetAccountById @id ", new object[] { id });
            foreach (DataRow r in T.Rows)
            {
                return new Account(r);
            }
            return new Account();
        }
        
        
        public bool SignUp(string username, string pass, string lname, string mname, string fname, string phone, string email, string address, DateTime dateOfBirth)
        {

            int result = 0;
            try
            {
                result = DataProvider.Instance.MyExecuteNonQuery(ref err, String.Format("EXEC dbo.proc_SignUp '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}', '{8}'", username, pass, lname, mname, fname, email,phone, dateOfBirth, address));
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return result > 0;
        }

        public string CountAccout()
        {
            return DataProvider.Instance.ExecuteScalar("SELECT dbo.fn_CountAccount()").ToString();
        }
    }
}
