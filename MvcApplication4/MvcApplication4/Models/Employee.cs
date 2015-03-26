using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MvcApplication4.App_GlobalResources;

namespace MvcApplication4.Models
{
    public class Employee
    {                
       //[Required(ErrorMessage="First Name is compulsory!!")]   
        //[Display(Name="FirstName",ResourceType=typeof(MvcApplication4.App_GlobalResources.Resource1))]
        [Required(ErrorMessageResourceType=(typeof(MvcApplication4.App_GlobalResources.Resource1)),ErrorMessageResourceName="FirstName")]
        public string FirstName { get; set; }    
        //[Required(ErrorMessage="Last Name is compulsory!!")]
        [Required(ErrorMessageResourceType=(typeof(MvcApplication4.App_GlobalResources.Resource1)),ErrorMessageResourceName="LastName")]
        public string LastName { get; set; }
        //[Required(ErrorMessage="Department is compulsory!!")]
        [Required(ErrorMessageResourceType=(typeof(MvcApplication4.App_GlobalResources.Resource1)),ErrorMessageResourceName="Department")]
        public string Department { get; set; }
        //[Required(ErrorMessage="Designation is compulsory!!")]
        [Required(ErrorMessageResourceType=(typeof(MvcApplication4.App_GlobalResources.Resource1)),ErrorMessageResourceName="Designation")]
        public string Designation { get; set; }        
    }
}