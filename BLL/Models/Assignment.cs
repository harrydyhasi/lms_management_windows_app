using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL.Models
{
    public class Assignment
    {
        public string AssignmentId { get; set; }
        public string SectionId { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime DueDate { get; set; }

        public Assignment()
        {

        }

        public Assignment(string assignmentId, string sectionId, string title, string desc, DateTime openDate, DateTime dueDate)
        {
            AssignmentId = assignmentId;
            SectionId = sectionId;
            Title = title;
            Desc = desc;
            OpenDate = openDate;
            DueDate = dueDate;
        }

        public Assignment(DataRow row)
        {
            AssignmentId = row["assignment_id"].ToString();
            SectionId = row["section_id"].ToString();
            Title = row["title"].ToString();
            Desc = row["desc"].ToString();
            OpenDate = (DateTime)row["open_date"];
            DueDate = (DateTime)row["due_date"];
        }
    }
}
