using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class File
    {
        public string FileId { get; }
        public string FileName { get; set; }
        public string SectionId { get; set; }
        public string Type { get; set; }
        public string FilePath { get; set; }
        public File()
        {

        }

        public File(string fileId,string fileName, string sectionId,string type, string filePath)
        {
            FileId = fileId;
            FileName = fileName;
            SectionId = sectionId;
            Type = type;
            FilePath = filePath;
        }

        public File(DataRow row)
        {
            FileId = row["file_id"].ToString();
            FileName = row["name"].ToString();
            SectionId = row["section_id"].ToString();
            Type = row["type"].ToString();
            FilePath = row["file_path"].ToString();
        }


    }
}
