using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningUserControl.Models
{
    internal class LoginModel
    {
        public string CompanyCode { get; set; }
        public string PhoneNumber { get; set; }
        public string? OTPCode { get; set; }
    }
}