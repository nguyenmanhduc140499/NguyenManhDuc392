using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NguyenManhDuc392.Models
{
    public class UniversityNMD392
    {
        [Key]
        public string UniversityID { get; set; }
        //public string StudentName { get; set; }
        public string UniversityName { get; set; }

    }
}