using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCoreCaptcha.Models
{
    public class SampleModel
    {
        [Required]
        [StringLength(4)]
        public string CaptchaCode { get; set; }
    }
}
