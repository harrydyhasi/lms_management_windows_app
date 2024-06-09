using BLL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File = BLL.Models.File;

namespace BLL
{
    public class FileBLL : BLLInterface<File>
    {
        private static FileBLL instance;
        public static FileBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FileBLL();
                }
                return FileBLL.instance;
            }

            private set
            {
                FileBLL.instance = value;
            }
        }
        public FileBLL()
        {

        }

        public List<File> getAll()
        {
            List<File> list = new List<File>();
            DataTable T = DataProvider.Instance.ExecuteQuery("SELECT * FROM [FILE]");
            foreach (DataRow row in T.Rows)
            {
                list.Add(new File(row));
            }
            return list;
        }
        public DataTable getAllFileOfCourse(string courseId)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC dbo.proc_MaterialOfCourse @course_id = " + courseId);
        }
        public DataTable getAllFileOfSection(string sectionId)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC dbo.proc_MaterialOfSection '" + sectionId + "'");
        }
        public int add(File t, ref string err)
        {
            return DataProvider.Instance.ExecuteNonQuery(ref err,
            "EXEC proc_AddFile @ne_file_name='" + t.FileName + "',@ne_section_id='"+
            t.SectionId+"',@ne_type='"+t.Type+ "',@ne_file_path='" + t.FilePath+"'");
        }

        int BLLInterface<File>.delete(File t, ref string err)
        {
            throw new NotImplementedException();
        }

        int BLLInterface<File>.update(File t, ref string err)
        {
            throw new NotImplementedException();
        }

        File BLLInterface<File>.getById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
