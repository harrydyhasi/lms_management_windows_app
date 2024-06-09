using BLL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VideoBLL : BLLInterface<Video>
    {
        private static VideoBLL instance;
        public static VideoBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new VideoBLL();
                }
                return VideoBLL.instance;
            }

            private set
            {
                VideoBLL.instance = value;
            }
        }
        public VideoBLL()
        {

        }
        public int add(Video t, ref string err)
        {
            return DataProvider.Instance.ExecuteNonQuery(ref err, "EXEC pro_AddVideo @section_id , @video_path ", new object[] {t.SectionId,t.VideoPath });
        }
        public int update(Video t, ref string err)
        {
            return 0;
        }
        public int delete(Video t, ref string err)
        {
            return 0;
        }
        public List<Video> getAll()
        {
            return new List<Video>();
        }
        public string getPathBySectionId(string id)
        {
            return (string)DataProvider.Instance.ExecuteScalar("select dbo.pro_GetVideoBySectionID('" + id + "') ").ToString();
        }
        public Video getById(string id)
        {
            DataTable T = DataProvider.Instance.ExecuteQuery("select dbo.pro_GetVideoBySectionID('" + id + "') ");
            foreach (DataRow r in T.Rows)
            {
                return new Video(r);
            }
            return new Video();
        }


    }
}