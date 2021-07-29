using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThebesDataEntryWebProject.Models
{
    public class Person
    {
        [Key]
        public int Person_ID { get; set; }
        public string Person_Name { get; set; }
        public string Person_Nationality { get; set; }
        public string Person_NationalID { get; set; }
        public string Person_Address { get; set; }
        public string Person_TelephoneNumber { get; set; }
        public string Person_PhoneNumber { get; set; }
        public string Person_Email { get; set; }
        public string Person_GraduationDate { get; set; }
        public string Person_Department { get; set; }
        public string Person_Division { get; set; }
        public string Person_Grad { get; set; }
        public string Person_PresentJob { get; set; }
        public string Person_CV_Destination { get; set; }
    }
}
