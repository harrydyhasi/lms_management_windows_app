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

    public class TakeQuestionBLL : BLLInterface<TakeQuestion>
    {
        private static TakeQuestionBLL instance;
        public static TakeQuestionBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TakeQuestionBLL();
                }
                return TakeQuestionBLL.instance;
            }

            private set
            {
                TakeQuestionBLL.instance = value;
            }
        }
        public TakeQuestionBLL()
        {

        }

        public List<TakeQuestion> getAll()
        {
            List<TakeQuestion> list = new List<TakeQuestion>();
            DataTable T = DataProvider.Instance.ExecuteQuery("SELECT * FROM TAKE_QUESTION");
            foreach (DataRow row in T.Rows)
            {
                list.Add(new TakeQuestion(row));
            }
            return list;
        }
        public DataTable getAllTakeQuestionOfTest(string testId)
        {
            throw new NotImplementedException();
        }

        public int add(TakeQuestion t, ref string err)
        {
            return DataProvider.Instance.ExecuteNonQuery(ref err, "EXEC dbo.proc_Add_Takes_Question @ne_learner_id = '"+ t.LearnerId+"', @ne_question_id='"+ t.QuestionId+"', @ne_answer_choice='"+t.AnswerChoice+"'");
        }

        int BLLInterface<TakeQuestion>.delete(TakeQuestion t, ref string err)
        {
            throw new NotImplementedException();
        }

        int BLLInterface<TakeQuestion>.update(TakeQuestion t, ref string err)
        {
            throw new NotImplementedException();
        }

        TakeQuestion BLLInterface<TakeQuestion>.getById(string id)
        {
            throw new NotImplementedException();
        }

    }
}

