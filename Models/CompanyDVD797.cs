using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DangVanDuc797Models
{
    public class CompanyDVD797
    {
        [Key]
        public int CompanyId{get;set;}
        [DisplayName("Tên công ty")]
        public string CompanyName{get;set;}
    }
}