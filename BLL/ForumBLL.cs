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
    public class ForumBLL : BLLInterface<Forum>
    {
        private static ForumBLL instance;
        public static ForumBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ForumBLL();
                }
                return ForumBLL.instance;
            }

            private set
            {
                ForumBLL.instance = value;
            }
        }

        public ForumBLL()
        {

        }

        public int add(Forum t, ref string err)
        {
            int result = 0;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(ref err, "EXEC AddForum @course_id , @name , @desc , @visibility", new object[] {t.CourseId, t.Name, t.Description, t.Visibility});
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return result;
        }

        public int delete(Forum t, ref string err)
        {
            int result = 0;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(ref err, "EXEC DeleteForum @forum_id", new object[] { t.Id});
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return result;
        }

        public List<Forum> getAll()
        {
            List<Forum> list = new List<Forum>();
            DataTable T = DataProvider.Instance.ExecuteQuery("SELECT * FROM FORUM");
            foreach (DataRow row in T.Rows)
            {
                list.Add(new Forum(row));
            }
            return list;
        }

        public Forum getById(string id)
        {
            DataTable T = DataProvider.Instance.ExecuteQuery("SELECT * FROM FORUM WHERE forum_id = '" + id + "'");
            foreach (DataRow r in T.Rows)
            {
                return new Forum(r);
            }
            return new Forum();
        }

        public int update(Forum t, ref string err)
        {
            int result = 0;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(ref err, "EXEC EditForum @forum_id , @name , @desc , @visibility", new object[] { t.Id, t.Name, t.Description, t.Visibility });
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return result;
        }

        public List<Forum> SearchForum(string key)
        {
            List<Forum> list = new List<Forum>();
            DataTable T = DataProvider.Instance.ExecuteQuery("select * FROM SearchForum('"+ key +"')");
            foreach (DataRow row in T.Rows)
            {
                list.Add(new Forum(row));
            }
            return list;
        }

        public List<Forum> getForumsByCourseId(string courseId)
        {
            List<Forum> list = new List<Forum>();
            DataTable T = DataProvider.Instance.ExecuteQuery("EXEC getForumsByCourseId @courseId", new object[] {courseId});
            foreach (DataRow row in T.Rows)
            {
                list.Add(new Forum(row));
            }
            return list;
        }
    }
}
