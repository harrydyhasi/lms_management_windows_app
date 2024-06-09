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
    public class CartBLL : BLLInterface<Cart>
    {
        private static CartBLL instance;
        public static CartBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CartBLL();
                }
                return CartBLL.instance;
            }

            private set
            {
                CartBLL.instance = value;
            }
        }
        public CartBLL()
        {

        }

        public DataTable getAll()
        {
            throw new NotImplementedException();
        }

        int BLLInterface<Cart>.add(Cart t, ref string err)
        {
            throw new NotImplementedException();
        }

        int BLLInterface<Cart>.delete(Cart t, ref string err)
        {
            throw new NotImplementedException();
        }

        int BLLInterface<Cart>.update(Cart t, ref string err)
        {
            throw new NotImplementedException();
        }

        public Cart getById (string id)
        {
            DataTable T = DataProvider.Instance.ExecuteQuery("EXEC dbo.pro_GetCartByID @id ", new object[] { id });
            foreach (DataRow r in T.Rows)
            {
                return new Cart(r);
            }
            return new Cart();
        }

        public Cart GetCartByUsername(string learnerId)
        {
            DataTable T = DataProvider.Instance.ExecuteQuery("EXEC pro_GetCartByUsername @learnerId", new object[]{ learnerId });
            foreach(DataRow r in T.Rows)
            {
                return new Cart(r);
            }
            return new Cart();

        }

        public bool RemoveItemInCart(string courseId, ref string err)
        {
            int result = 0;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(ref err, "EXEC pro_RemoveItemInCart @id", new object[] { courseId });
            }
            catch(Exception e)
            {
                err = e.Message;
            }
            return result > 0;
        }

        public List<String> GetItemsListInCartByIdCart (string idCart)
        {
            List<string> result = new List<string> { };
            DataTable T = DataProvider.Instance.ExecuteQuery("EXEC pro_GetItemsListInCartByIdCart @id", new object[] { idCart });
            foreach(DataRow r in T.Rows)
            {
                result.Add(r["course_id"].ToString());
            }
            return result;
        }

        public bool AddItemToCart(string courseId, string cartId, ref string err)
        {
            int result = 0;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(ref err, "EXEC dbo.pro_AddItemToCart @courseId , @cartId", new object[] { courseId, cartId });

            }
            catch(Exception e)
            {
                err = e.Message;
            }
            return result > 0;
        }

        public int GetQuantity(string cartId)
        {
            string query = "SELECT dbo.fn_CountItemsInCart('" + cartId + "')";
            int result =  (int)(DataProvider.Instance.ExecuteScalar(query));
            return result;
        }

        List<Cart> BLLInterface<Cart>.getAll()
        {
            throw new NotImplementedException();
        }

        public void RemoveAllItemsInCart(string cart_id, ref string err)
        {
            int result = 0;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(ref err, "delete purchased_course where cart_id = '"+cart_id+"'");

            }
            catch (Exception e)
            {
                err = e.Message;
            }
        }
    }
}
