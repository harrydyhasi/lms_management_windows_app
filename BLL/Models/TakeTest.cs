using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class TakeTest
    {
        public string LearnerId { get; set; }
        public string TestId { get; set; }
        public string Time { get; set; }
        public TakeTest()
        {

        }

        public TakeTest(string learnerId,string testId, string time)
        {
            LearnerId = learnerId;
            TestId = testId;
            Time = time;
        }

        public TakeTest(DataRow row)
        {
            LearnerId = row["learner_id"].ToString();
            TestId = row["test_id"].ToString();
            Time = row["time"].ToString();
        }
    }
}
