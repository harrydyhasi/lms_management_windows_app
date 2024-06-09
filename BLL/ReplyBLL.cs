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
    public class ReplyBLL : BLLInterface<Reply>
    {
        private static ReplyBLL instance;
        public static ReplyBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReplyBLL();
                }
                return ReplyBLL.instance;
            }

            private set
            {
                ReplyBLL.instance = value;
            }
        }

        public ReplyBLL()
        {

        }

        public List<Reply> getAll()
        {
            throw new NotImplementedException();
        }

        public int add(Reply t, ref string err)
        {
            throw new NotImplementedException();
        }

        public int delete(Reply t, ref string err)
        {
            throw new NotImplementedException();
        }

        public int update(Reply t, ref string err)
        {
            throw new NotImplementedException();
        }

        public Reply getById(string id)
        {
            return new Reply();
        }

        public Reply getPostById(string id, string author)
        {
            DataTable T = DataProvider.Instance.ExecuteQuery("select * from reply where post_id = '" + id + "' and author = '" + author + "'");
            foreach (DataRow r in T.Rows)
            {
                return new Reply(r);
            }
            return new Reply();
        }



        public List<Reply> getReplysOfPost(string postId)
        {
            List<Reply> lst = new List<Reply>();
            DataTable T = DataProvider.Instance.ExecuteQuery("select * from reply where post_id = '" + postId + "'");
            foreach(DataRow a in T.Rows)
            {
                lst.Add(new Reply(a));
            }
            return lst;
        }
    }
}
