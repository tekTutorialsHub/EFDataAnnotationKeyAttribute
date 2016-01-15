using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDataAnnotationKeyAttribute
{

    //Code First Default Convention. EmployeeID is Primary key
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
    }


    //EmployeeCode is Primary Key and identity Column
    public class Employee1
    {
        public int EmployeeID { get; set; }
        [Key]
        public int EmployeeCode { get; set; }
        public string Name { get; set; }
    }


    //EmployeeCode is Primary Key.

    public class Employee2
    {
        public int EmployeeID { get; set; }
        [Key]
        public string EmployeeCode { get; set; }
        public string Name { get; set; }
    }


    //EmployeeCode is Primary Key. Identity is disabled
    public class Employee3
    {
        public int EmployeeID { get; set; }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeCode { get; set; }
        public string Name { get; set; }
    }



    public class Employee4
    {
        public int EmployeeID { get; set; }

        public int EmployeeNo { get; set; }

        [Key]
        [Column(Order = 1)]
        public int EmployeeKey1 { get; set; }

        [Key]
        [Column(Order = 2)]
        public int EmployeeKey2 { get; set; }
    }




}
