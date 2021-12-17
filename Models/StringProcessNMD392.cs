using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NguyenManhDuc392.Models
{
    public class StringProcessNMD392
    {
        public string LowerToUpper(string text)
        {
            return text.ToUpper();
        }

    }
}