using BLL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace BLL
{
    public class TestBLL : BLLInterface<Test>

    {
        private static TestBLL instance;
        public static TestBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TestBLL();
                }
                return TestBLL.instance;
            }

            private set
            {
                TestBLL.instance = value;
            }
        }
        public TestBLL()
        {

        }


        List<Test> BLLInterface<Test>.getAll()
        {
            List<Test> list = new List<Test>();
            DataTable T = DataProvider.Instance.ExecuteQuery("SELECT * FROM TEST");
            foreach (DataRow row in T.Rows)
            {
                list.Add(new Test(row));
            }
            return list;
        }
        public DataTable getAllTestOfCourse(string courseId)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC dbo.proc_TestOfCourse @course_id = " + courseId);
        }
        public DataTable getAllTestOfSection(string sectionId)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC dbo.proc_TestOfSection @section_id = " + sectionId);
        }
        public string GetLastestAddedTest()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT dbo.fn_Get_TestId_With_Max_Id()");
            return (string)(data.Rows[0][0]);
        }
        public int add(Test t, ref string err)
        {
            return DataProvider.Instance.ExecuteNonQuery(ref err, "EXEC proc_AddTest @ne_section_id , @ne_name , @ne_time ", new object[] { t.SectionId, t.Name, t.Time });
        }

        int BLLInterface<Test>.delete(Test t, ref string err)
        {
            throw new NotImplementedException();
        }

        int BLLInterface<Test>.update(Test t, ref string err)
        {
            throw new NotImplementedException();
        }

        Test BLLInterface<Test>.getById(string id)
        {
            throw new NotImplementedException();
        }
        public static DataTable proc_TestOfCourse()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC dbo.proc_Test_Of_Course @course_id = 'CO001'");
        }
        public static void SubmitTest()
        {

        }
    }
}
