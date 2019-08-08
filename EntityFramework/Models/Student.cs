using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Xunit;

namespace EntityFramework.Models {
    public class Student {

        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string firstName { get; set; }
        [Required]
        [StringLength(30)]
        public string lastName { get; set; }
        [Range(600, 2400, ErrorMessage = "Invalid SAT Score: Only Scores between 600 and 2400 allowed!")]
        public int SAT { get; set; }
        public double GPA { get; set; }
        public bool isFullTime { get; set; } = true;

        public int? MajorId { get; set; }
        public virtual Major Major { get; set; }

        public Student() {

        }
        public Student (string firstname, string lastname, int sat, double gpa, bool ft, string major) {
            this.firstName = firstname;
            this.lastName = lastname;
            this.SAT = sat;
            this.GPA = gpa;
            this.isFullTime = ft;
            var context = new AppDbContext();
            this.MajorId = context.Majors.SingleOrDefault(m => m.Description == major) == null
                ? null
                : (int?)context.Majors.SingleOrDefault(m => m.Description == major).Id;
        }
        public override string ToString() {
            var major = (this.Major == null)
                    ? "Undeclared"
                    : this.Major.Description;
            return $"{this.firstName} {this.lastName} GPA[{this.GPA}] SAT[{this.SAT}] {Environment.NewLine}" +
                $"Fulltime: {this.isFullTime} and is Majoring in {major}";
        }

       
    }
}
