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
    public class PostBLL : BLLInterface<Post>
    {
        private static PostBLL instance;
        public static PostBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PostBLL();
                }
                return PostBLL.instance;
            }

            private set
            {
                PostBLL.instance = value;
            }
        }

        public PostBLL()
        {

        }

        public List<Post> getAll()
        {
            throw new NotImplementedException();
        }

        public int add(Post t, ref string err)
        {
            int result = 0;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(ref err, "EXEC AddPost @forumId , @author , @content , @title", new object[] { t.ForumId, t.Author, t.Content, t.Title });
            }
            catch(Exception e)
            {
                err = e.Message;
            }
            return result;
        }

        public int delete(Post t, ref string err)
        {
            throw new NotImplementedException();
        }

        public int update(Post t, ref string err)
        {
            int result = 0;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(ref err, "EXEC EditPost @post_id , @content", new object[] { t.PostId, t.Content});
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return result;
        }

        public Post getById(string id)
        {
            DataTable T = DataProvider.Instance.ExecuteQuery("SELECT * FROM POST WHERE post_id = '" + id + "'");
            foreach (DataRow r in T.Rows)
            {
                return new Post(r);
            }
            return new Post();
        }

        public List<Post> getPostsOfForum(string forumId)
        {
            List<Post> lst = new List<Post> ();
            DataTable T = DataProvider.Instance.ExecuteQuery("SELECT * FROM GetPostOfForum('"+ forumId + "')");
            foreach(DataRow r in T.Rows)
            {
                lst.Add(new Post(r));
            }
            return lst;
        }

        public bool Like(string postId, string author, ref string err)
        {
            int result = 0;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(ref err, "INSERT INTO [LIKE] VALUES ('" + postId + "', '" + author + "')");
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return result > 0;
        }

        public bool UnLike(string postId, string author, ref string err)
        {
            int result = 0;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(ref err, "DELETE [LIKE] where post_id = '"+postId+"' AND author = '"+author+"'");
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return result > 0;
        }

        public bool isLike(string postId, string author, ref string err)
        {
            if (PostBLL.Instance.Like(postId, author, ref err))
                return false;
            return true;
        }


    }
}
