using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DAL;
using System.Data;

namespace BLL
{
    public class AssignmentBLL : BLLInterface<Assignment>
    {
        private static AssignmentBLL instance;
        public static AssignmentBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AssignmentBLL();
                }
                return AssignmentBLL.instance;
            }

            private set
            {
                AssignmentBLL.instance = value;
            }
        }
        public AssignmentBLL()
        {

        }

        public List<Assignment> getAll()
        {
            List<Assignment> list = new List<Assignment>();
            DataTable T = DataProvider.Instance.ExecuteQuery("SELECT * FROM ASSIGNMENT");
            foreach (DataRow row in T.Rows)
            {
                list.Add(new Assignment(row));
            }
            return list;
        }
        public DataTable getAllAssignmentOfCourse(string courseId)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC dbo.proc_AssignmentOfCourse @course_id = " + courseId);
        }
        public DataTable getAllAssignmentOfSection(string sectionId)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC dbo.proc_AssignmentOfSection @section_id = " + sectionId);
        }

        public int add(Assignment t, ref string err)
        {
            return DataProvider.Instance.ExecuteNonQuery(ref err, "EXEC dbo.proc_AddAssignment @ne_section_id , @ne_title , @ne_desc , @ne_open_date , @ne_due_date", new object[] { t.SectionId, t.Title, t.Desc, t.OpenDate, t.DueDate });
        }

        int BLLInterface<Assignment>.delete(Assignment t, ref string err)
        {
            throw new NotImplementedException();
        }

        int BLLInterface<Assignment>.update(Assignment t, ref string err)
        {
            throw new NotImplementedException();
        }

        Assignment BLLInterface<Assignment>.getById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
