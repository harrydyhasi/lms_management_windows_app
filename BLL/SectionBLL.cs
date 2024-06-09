using System.Data;
using System.Data.SqlClient;
using BLL.Models;
using DAL;


namespace BLL
{
    public class SectionBLL : BLLInterface<Section>
    {
        private static SectionBLL instance;
        public static SectionBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SectionBLL();
                }
                return SectionBLL.instance;
            }

            private set
            {
                SectionBLL.instance = value;
            }
        }

        public SectionBLL()
        {

        }

        List<Section> BLLInterface<Section>.getAll()
        {
            List<Section> list = new List<Section>();
            DataTable T = DataProvider.Instance.ExecuteQuery("SELECT * FROM SECTION");
            foreach (DataRow row in T.Rows)
            {
                list.Add(new Section(row));
            }
            return list;
        }
        public DataTable getAllSectionOfCourse(string courseId)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC dbo.proc_Section_List @course_id = " + courseId);
        }

        public DataTable getCompletionOfSection(string courseId)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT completion FROM SECTION WHERE course_id = '"+ courseId +"'");
        }


        public int add(Section t, ref string err)
        {
            return DataProvider.Instance.ExecuteNonQuery(ref err, "EXEC dbo.proc_AddSection @ne_course_id , @ne_name ", new object[] {  t.CourseId, t.Name });

        }
        public void SetCompletion(string sectionId,ref string err)
        {
            try
            {
                string query = "EXEC dbo.proc_SetCompletion @section_id";
                int result = DataProvider.Instance.ExecuteNonQuery(ref err, query, new object[] { sectionId});
            }
            catch (SqlException ex)
            {
                err = ex.Message;
            }

        }

        int BLLInterface<Section>.delete(Section t, ref string err)
        {
            throw new NotImplementedException();
        }

        int BLLInterface<Section>.update(Section t, ref string err)
        {
            throw new NotImplementedException();
        }

        Section BLLInterface<Section>.getById(string id)
        {
            throw new NotImplementedException();
        }

    }
}
