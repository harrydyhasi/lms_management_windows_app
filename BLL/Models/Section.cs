using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Section
    {

        //public string SectionId { get; }
        public string Name { get; set; }
        public string CourseId { get; }


        public Section()
        {

        }

        public Section( string name, string courseId)
        {
            
            Name = name;
            CourseId = courseId;
        }

        public Section(DataRow row)
        {
            //SectionId = row["section_id"].ToString();
            Name = row["name"].ToString();
            CourseId = row["course_id"].ToString();
        }
    }
}
