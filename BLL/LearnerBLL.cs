using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;
using DAL;

namespace BLL
{
    public class LearnerBLL : BLLInterface<Learner>
    {
        private static LearnerBLL instance;
        public static LearnerBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LearnerBLL();
                }
                return LearnerBLL.instance;
            }

            private set
            {
                LearnerBLL.instance = value;
            }
        }
        public LearnerBLL()
        {

        }

        public DataTable getAll()
        {
            throw new NotImplementedException();
        }

        int BLLInterface<Learner>.add(Learner t, ref string err)
        {

            return DataProvider.Instance.ExecuteNonQuery(ref err,"");
        }


        int BLLInterface<Learner>.delete(Learner t, ref string err)
        {
            throw new NotImplementedException();
        }

        int BLLInterface<Learner>.update(Learner t, ref string err)
        {
            throw new NotImplementedException();
        }

        Learner BLLInterface<Learner>.getById(string id)
        {
            throw new NotImplementedException();
        }

        public Learner GetLearnerByUsername(string userName)
        {
            DataTable T = DataProvider.Instance.ExecuteQuery("EXEC pro_GetLearnerByUsername @username", new object[] {userName});
            foreach(DataRow r in T.Rows)
            {
                return new Learner(r);
            }
            return new Learner();
        }

        List<Learner> BLLInterface<Learner>.getAll()
        {
            throw new NotImplementedException();
        }
    }
}
