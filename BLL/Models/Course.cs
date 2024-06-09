using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Course
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }  
        public string LecturerId { get; set; }
        public float OriginalPrice { get; set; }
        public float Discount { get; set; }
        public float SellingPrice { get; set; }
        public float AvgRating { get; set; }
        public int Completion { get; set; }
        public DateTime Delete_at { get; set; }
        public Course()
        {

        }

        public Course(string courseId, string courseName, string lecturerId, float originalPrice, float discount, float sellingPrice, float avgRating)
        {
            CourseId = courseId;
            CourseName = courseName;
            LecturerId = lecturerId;
            OriginalPrice = originalPrice;
            Discount = discount;
            SellingPrice = sellingPrice;
            AvgRating = avgRating;
        }

        public Course(DataRow row, bool isLec)
        {
            if (isLec)
            {
                CourseId = row["course_id"].ToString();
                CourseName = row["name"].ToString();
                LecturerId = row["lecturer_id"].ToString();
            }
            else
            {
                CourseId = row["course_id"].ToString();
                CourseName = row["name"].ToString();
                LecturerId = row["lecturer_id"].ToString();
                OriginalPrice = float.Parse(row["original_price"].ToString());
                Discount = float.Parse(row["discount"].ToString());
                SellingPrice = float.Parse(row["selling_price"].ToString());
                AvgRating = float.Parse(row["avg_rating"].ToString());
                if (row["deleted_at"].ToString() != "")
                    Delete_at = Convert.ToDateTime(row["deleted_at"].ToString());
            }
            
        }
    }
}
