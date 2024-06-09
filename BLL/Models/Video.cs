using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Video
    {
        public string SectionId { get; set; }
        public string VideoPath { get; set; }

        public Video()
        {

        }
        public Video(string sectionId, string videoPath)
        {
            this.SectionId = sectionId;
            this.VideoPath = videoPath;
        }
        public Video(DataRow row)
        {
            SectionId = row["section_id"].ToString();
            VideoPath = row["video_path"].ToString();
        }
    }
}