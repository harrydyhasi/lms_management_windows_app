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

    public class TakeTestBLL : BLLInterface<TakeTest>
    {
        private static TakeTestBLL instance;
        public static TakeTestBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TakeTestBLL();
                }
                return TakeTestBLL.instance;
            }

            private set
            {
                TakeTestBLL.instance = value;
            }
        }
        public TakeTestBLL()
        {

        }

        public List<TakeTest> getAll()
        {
            List<TakeTest> list = new List<TakeTest>();
            DataTable T = DataProvider.Instance.ExecuteQuery("SELECT * FROM TAKE_TEST");
            foreach (DataRow row in T.Rows)
            {
                list.Add(new TakeTest(row));
            }
            return list;
        }
        public DataTable getAllTakeTestOfTest(string testId)
        {
            throw new NotImplementedException();
        }
        public int GetScoreByTakeTestID(string testId, string learnerId)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT dbo.fn_ScoreOfTakeTest('"+ testId + ",'" + learnerId + "')");
            return (int)(data.Rows[0][0]);
        }
        public int add(TakeTest t, ref string err)
        {
            return DataProvider.Instance.ExecuteNonQuery(ref err, "EXEC dbo.proc_Add_Takes_Test @ne_learner_id = '" + t.LearnerId + "', @ne_test_id='" + t.TestId + "', @ne_submitted_date='" + t.Time + "'");
        }

        int BLLInterface<TakeTest>.delete(TakeTest t, ref string err)
        {
            throw new NotImplementedException();
        }

        int BLLInterface<TakeTest>.update(TakeTest t, ref string err)
        {
            throw new NotImplementedException();
        }

        TakeTest BLLInterface<TakeTest>.getById(string id)
        {
            throw new NotImplementedException();
        }
        
        public int isExist(string TestId, string LearnerId)
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT dbo.fn_isExistTakeTest ('" + TestId + "', '" + LearnerId + "')");
        }
    }
}

