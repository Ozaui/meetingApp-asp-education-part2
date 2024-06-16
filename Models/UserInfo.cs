using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace meetingApp_asp_education_part2.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Lutfen isim alanini doldurunuz")]
        public string? name { get; set; }
        [Required(ErrorMessage = "Lutfen telefon alanini doldurunuz")]
        public string? phone { get; set; }
        [Required(ErrorMessage = "Lutfen mail alanini doldurunuz")]
        [EmailAddress]
        public string? email { get; set; }
        [Required(ErrorMessage = "Lutfen katilim yapip yapmayacaginizi seciniz")]
        public bool? willAttend { get; set; }
    }
}