using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Reply
    {
        public string PostId;
        public string Author;
        public string Content;

        public Reply()
        {

        }

        public Reply(string postId, string author, string content)
        {
            PostId = postId;
            Author = author;
            Content = content;
        }

        public Reply(DataRow row)
        {
            PostId = row["post_id"].ToString();
            Author = row["author"].ToString();
            Content = row["content"].ToString();
        }
    }
}
