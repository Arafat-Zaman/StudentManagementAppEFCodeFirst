

using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementAppEFCodeFirst.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [StringLength(50)]
        public string Major { get; set; }
    }
}

