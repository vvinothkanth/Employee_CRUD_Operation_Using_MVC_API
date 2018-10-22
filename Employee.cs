using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CURDOperationUsingAjax.Models
{
    public class Employee
    {
        
        public int EmployeeID { get; set; }

        
        public string Name { get; set; }

        
        public int Age { get; set; }

        
        public string State { get; set; }

        
        public string Country { get; set; }

        
        public string ImageUrl { get; set; }


        public HttpPostedFileBase ImageUpload { get; set; }

        public Employee()
        {
            ImageUrl = "~/App_Files/Images/ProfilePic.jpg";
            

        }
    }

}