using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using File = BLL.Models.File;

namespace UI.Course
{
    public partial class frmUploadFile : Form
    {
        public string FileName { get; set; }
        public string Type { get; set; }
        public string FilePath { get; set; }
        private string SectionId;
        public frmUploadFile(string sectionId)
        {
            InitializeComponent();
            SectionId = sectionId;
        }

        private void siticoneButton_Browse_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.TextboxFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void siticoneTextBox_FileName_TextChanged(object sender, EventArgs e)
        {
            if(this.TextboxFilePath.Text != null)
            {
                this.siticoneButton_Browse.Enabled = false;
            }
        }

        private void ButtonUpload_Click(object sender, EventArgs e)
        {
            File t = new File();
            t.FileName = this.TextboxFileName.Text;
            t.SectionId = SectionId;
            t.Type = this.TypesOfFile.Text;
            t.FilePath = this.TextboxFilePath.Text;
            FileBLL fileBLL = new FileBLL();
            string err = string.Empty;
            if(fileBLL.add(t, ref err) == 0)
            {
                MessageBox.Show(err);
            }
            else
            {
                this.Close();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*public static void FileUploadInFolder(string folderId, string path, DriveService service)
        {
            var FileMetaData = new Google.Apis.Drive.v3.Data.File()
            {
                Name = Path.GetFileName(path),
                MimeType = GetMimeType(path),
                //id of parent folder 
                Parents = new List<string>
                {
                    folderId
                }
            };
            FilesResource.CreateMediaUpload request;
            //create stream and upload
            using (var stream = new System.IO.FileStream(path, System.IO.FileMode.Open))
            {
                request = service.Files.Create(FileMetaData, stream, FileMetaData.MimeType);
                request.Fields = "id";
                request.Upload();
            }
            var file1 = request.ResponseBody;
        }*/
    }
}
