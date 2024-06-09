using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Forum
    {
        public string Id;
        public string Name;
        public string Description;
        public string CourseId;
        public bool Visibility;
        public DateTime CreationDate;


        public Forum()
        {

        }

        public Forum(string courseId, string name, string desc, bool visibility)
        {
            Name = name;
            CourseId = courseId;
            Visibility = visibility;
            Description = desc;
        }

        public Forum(DataRow row)
        {
            Id = row["forum_id"].ToString();
            CourseId = row["course_id"].ToString();
            Name = row["name"].ToString();
            Description = row["description"].ToString();
            CreationDate = Convert.ToDateTime(row["creation_date"].ToString());
            Visibility = (bool)(row["visibility"]);
        }
    }
}
