using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NguyenManhDuc392.Models
{
    public class NMD392
    {
        [Key]
        public string NMDID { get; set; }
        public string NMDName { get; set; }
        public bool NMDGende { get; set; }

    }
}