using BLL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CouponBLL : BLLInterface<Coupon>
    {
        private static CouponBLL instance;
        public static CouponBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CouponBLL();
                }
                return CouponBLL.instance;
            }

            private set
            {
                CouponBLL.instance = value;
            }
        }
        public CouponBLL()
        {

        }

        public List<Coupon> getAll()
        {
            List<Coupon> list = new List<Coupon>();

            DataTable T = DataProvider.Instance.ExecuteQuery("SELECT * FROM Coupon_list");

            foreach (DataRow row in T.Rows)
            {
                list.Add(new Coupon(row));
            }
            return list;
        }

        public int add(Coupon t, ref string err)
        {
            int result = 0;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(ref err, String.Format("EXEC proc_AddCoupon '{0}' , '{1}' , '{2}' , {3} , '{4}'", t.Code, t.ValidDate, t.ExpireDate, t.UseValue, t.CourseId));
            }
            catch(Exception e)
            {
                err = e.Message;
            }
            return result;
        }

        public string RandomCode()
        {
            return DataProvider.Instance.ExecuteScalar("EXEC dbo.proc_Create_Coupon_Code").ToString();
        }

        public int delete(Coupon t, ref string err)
        {
            throw new NotImplementedException();
        }

        public int Delete(string id, ref string err)
        {
            int result = 0;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(ref err, String.Format("EXEC proc_DeleteCoupon '{0}'", id));
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return result;
        }
        public int update(Coupon t, ref string err)
        {
            int result = 0;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(ref err, String.Format("EXEC proc_UpdateCoupon '{0}' , '{1}' , '{2}' , '{3}' , {4} , '{5}'",t.Id, t.Code, t.ValidDate, t.ExpireDate, t.UseValue, t.CourseId ));
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return result;
        }

        public Coupon getById(string id)
        {
            throw new NotImplementedException();
        }

        public int isExist(string code)
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT dbo.fn_isExistCoupon ('" + code + "')");
        }
    }
}
