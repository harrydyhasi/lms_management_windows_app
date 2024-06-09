using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Test
    {
        public string TestId { get; set; }
        public string Name { get; set; }
        public string SectionId { get; set; }
        public int Time { get; set; }

        public Test()
        {

        }

        public Test(string testId, string name, string sectionId, int time)
        {
            TestId = testId;
            Name = name;
            SectionId = sectionId;
            Time = time;
        }
        public Test(DataRow row)
        {
            TestId = row["test_id"].ToString();
            Name = row["test_name"].ToString();
            SectionId = row["section_id"].ToString();
            Time = (int)row["time"];
        }

    }
}
