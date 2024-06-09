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
    public class CourseBLL : BLLInterface<Course>
    {
        private static CourseBLL instance;
        public static CourseBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CourseBLL();
                }
                return CourseBLL.instance;
            }

            private set
            {
                CourseBLL.instance = value;
            }
        }
        public CourseBLL()
        {

        }
        public List<Course> getLearnerCourseCompleted(string learnerId)
        {
            List<Course> lst = new List<Course>();
            DataTable T = DataProvider.Instance.ExecuteQuery("SELECT * FROM LearnerCourseCompleted('" + learnerId + "')");
            foreach (DataRow r in T.Rows)
            {
                lst.Add(new Course(r, true));
            }
            return lst;
        }
        public List<Course> getLearnerCourseInProgress(string lecId)
        {
            List<Course> lst = new List<Course>();
            DataTable T = DataProvider.Instance.ExecuteQuery("SELECT * FROM LearnerCourseInProgress('" + lecId + "')");
            foreach (DataRow r in T.Rows)
            {
                lst.Add(new Course(r, true));
            }
            return lst;
        }
        public List<string> getLearnerCourseInHome(string learnerId)
        {
            List<string> list = new List<string>();
            DataTable T = DataProvider.Instance.ExecuteQuery("SELECT * FROM GetLearnerCourseInHome('" + learnerId + "')");
            foreach (DataRow r in T.Rows)
            {
                list.Add(r["course_id"].ToString());
            }
            return list;
        }

        public Course getById(string id)
        {
            DataTable T = DataProvider.Instance.ExecuteQuery("EXEC dbo.pro_GetCourseByID @id ", new object[] { id});
            foreach (DataRow r in T.Rows)
            {
                return new Course(r,false);
            }
            return new Course();
        }

        public List<Course> getAll()
        {
            List<Course> list = new List<Course>();
            DataTable T = DataProvider.Instance.ExecuteQuery("SELECT * FROM COURSE");
            foreach (DataRow row in T.Rows)
            {
                list.Add(new Course(row,false));
            }
            return list;
        }

        public int add(Course t, ref string err)
        {
            int result = 0;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(ref err, "EXEC dbo.proc_AddCourse @lecturer_id , @name , @original_price , @discount , @selling_price , @avg_rating", new object[] { t.LecturerId, t.CourseName, t.OriginalPrice, t.Discount, t.SellingPrice, t.AvgRating });

            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return result;
        }

        public int delete(Course t, ref string err)
        {
            
            return 0;
        }

        public int DeleteCourse(string courseId, ref string err)
        {
            int result = 0;
            try
            {
                result = DataProvider.Instance.MyExecuteNonQuery(ref err, String.Format("EXEC dbo.proc_DeleteCourse '{0}', '{1}'", courseId, DateTime.Now));

            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return result;
        }
        public int update(Course t, ref string err)
        {
            int result = 0;
            try
            {
                result = DataProvider.Instance.MyExecuteNonQuery(ref err, String.Format("EXEC dbo.proc_UpdateCourse '{0}', '{1}', '{2}', {3} , {4}, {5}, {6}",t.CourseId, t.LecturerId, t.CourseName, t.OriginalPrice, t.Discount, t.SellingPrice, t.AvgRating));

            }
            catch (Exception e)
            {
                err = e.Message;
            }
            
            return result;
        }
        public int GetNumberLeaner(string id)
        {
            return (int)DataProvider.Instance.ExecuteScalar("select dbo.fn_CountNumberLearner('" + id + "')");
        }
        public string GetCourseName(string courseid)
        {
            return (string)DataProvider.Instance.ExecuteScalar("select dbo.fn_Get_Course_Name('" + courseid + "')");
        }

        public DataTable GetLeanerByCourse(string courseid)
        {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(String.Format("select * from dbo.fn_LstLearnerCourse('{0}')", courseid));
            return dt;
        }
        

        public DataTable SearchCourseByName(string name)
        {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery("EXEC dbo.proc_searchCourseByName @name ", new object[] {name});
            return dt;
        }

        public DataTable SearchCourseById(string id)
        {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery("EXEC dbo.proc_searchCourseById @id ", new object[] { id });
            return dt;
        }
        public string CountCourse()
        {
            return DataProvider.Instance.ExecuteScalar("select dbo.fn_CountCourse()").ToString();
        }

        public Course getCourseInEntrolls(string learner, string courseId)
        {
            DataTable T = DataProvider.Instance.ExecuteQuery("SELECT * FROM getCourseInEntrolls('"+ courseId + "','"+ learner + "')");
            foreach (DataRow r in T.Rows)
            {
                return new Course(r, true);
            }
            return new Course();
        }
        public List<string> ListId()
        {
            List<string> list = new List<string>();
            DataTable T = DataProvider.Instance.ExecuteQuery("select * from CourseID_list");
            foreach (DataRow row in T.Rows)
            {
                list.Add(row["course_id"].ToString());
            }
            return list;
        }

        public List<Course> getCourseByLecturerId(string lecId)
        {

            List<Course> lst = new List<Course>();
            DataTable T = DataProvider.Instance.ExecuteQuery("EXEC proc_getCourseByLecturerId @lecId", new object[] {lecId});
            foreach(DataRow r in T.Rows)
            {
                lst.Add(new Course(r,true));
            }
            return lst;
        }

        public bool EnrollCourse(string learnerId, string course_id, ref string err)
        {
            int result = 0;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(ref err, "EXEC  EnrollCourse @learnerId , @course_id", new object[] { learnerId, course_id });
            }
            catch(Exception e)
            {
                err = e.Message;
            }
            return result > 0;
        }


        public void SetCompletion(string courseId)
        {
            bool isCompletion = false;
            DataTable sections = SectionBLL.Instance.getCompletionOfSection(courseId);
            
            for(int i = 0; i < sections.Rows.Count; i++)
            {
                if (sections.Rows[i][0]=="100")
                {
                    isCompletion=true;
                }
                else
                {
                    isCompletion=false;
                    break;
                }
            }
            if (isCompletion)
            {
                DataProvider.Instance.ExecuteQuery("EXEC proc_SetCompletionCourse '" + courseId + "'");
            }
        }

    }
}
