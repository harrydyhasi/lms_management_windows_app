using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Post
    {
        public string PostId;
        public string ForumId;
        public string Author;
        public string Content;
        public int Likes;
        public int Replys;
        public string Title;

        public Post()
        {

        }

        public Post(string postId, string forumId, string author, string content, int likes, int replys, string title)
        {
            PostId = postId;
            ForumId = forumId;
            Author = author;
            Content = content;
            Likes = likes;
            Replys = replys;
            Title = title;
        }

        public Post(DataRow row)
        {
            PostId = row["post_id"].ToString();
            ForumId = row["forum_id"].ToString();
            Author = row["author"].ToString();
            Content = row["content"].ToString();
            Likes = int.Parse(row["likes"].ToString());
            Replys = int.Parse(row["replys"].ToString());
            Title = row["title"].ToString();
        }
    }
}
