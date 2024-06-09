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
    public class QuestionBLL : BLLInterface<Question>
    {
        private static QuestionBLL instance;
        public static QuestionBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new QuestionBLL();
                }
                return QuestionBLL.instance;
            }

            private set
            {
                QuestionBLL.instance = value;
            }
        }
        public QuestionBLL()
        {

        }

        List<Question> BLLInterface<Question>.getAll()
        {
            List<Question> list = new List<Question>();
            DataTable T = DataProvider.Instance.ExecuteQuery("SELECT * FROM QUESTION");
            foreach (DataRow row in T.Rows)
            {
                list.Add(new Question(row));
            }
            return list;
        }
        public DataTable getAllQuestionOfTest(string testId)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC dbo.proc_Question_List @test_id = " + testId);
        }


        public int add(Question t, ref string err)
        {
            return DataProvider.Instance.ExecuteNonQuery(ref err, "EXEC proc_AddQuestion @ne_test_id , @ne_text , @ne_type , @ne_point , @ne_choices , @ne_correct_answer ", new object[] { t.TestId, t.Text, t.Type, t.Point, t.Choices, t.CorrectAnswer });
        }

        int BLLInterface<Question>.delete(Question t, ref string err)
        {
            throw new NotImplementedException();
        }

        int BLLInterface<Question>.update(Question t, ref string err)
        {
            throw new NotImplementedException();
        }

        Question BLLInterface<Question>.getById(string id)
        {
            throw new NotImplementedException();
        }

    }
}

