using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Coupon
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public DateTime ValidDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public float UseValue { get; set; }
        public string CourseId { get; set; }

        public Coupon()
        {

        }

        public Coupon(string code, DateTime validDate, DateTime expireDate, float useValue, string course_id)
        {
            Code = code;
            ValidDate = validDate;
            ExpireDate = expireDate;
            UseValue = useValue;
            CourseId = course_id;
        }
        public Coupon(string id, string code, DateTime validDate, DateTime expireDate, float useValue, string course_id)
        {   
            Id = id;
            Code = code;
            ValidDate = validDate;
            ExpireDate = expireDate;
            UseValue = useValue;
            CourseId = course_id;
        }

        public Coupon(DataRow row)
        {
            Id = row["coupon_id"].ToString();
            Code = row["code"].ToString();
            ValidDate = Convert.ToDateTime(row["valid_date"].ToString());
            ExpireDate = Convert.ToDateTime(row["valid_date"].ToString());
            UseValue = float.Parse(row["use_value"].ToString());
            CourseId = row["course_id"].ToString();
        }
    }
}
