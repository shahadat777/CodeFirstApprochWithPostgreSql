using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UMS.Models
{
    public class Student
        
    {
      
        public int  Id{ get; set; }
       

        public string  StudentName{ get; set; }
      
        
        public string  RegNo{ get; set; }
     
        public string  Email{ get; set; }

       
        public string  DepartmentName{ get; set; }


    }
}
