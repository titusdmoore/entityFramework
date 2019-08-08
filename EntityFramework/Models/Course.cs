using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace EntityFramework.Models {
    public class Course {
        public int Id { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Invalid Name: Name length cannot be more than 30")]
        public string Name { get; set; }
        [MaxLength(30, ErrorMessage = "Invalid Instructor: Instructor length cannot be more than 30")]
        public string Instructor { get; set; }
        public int Credits { get; set; }
        public int? MajorId { get; set; }
        public virtual Major Major { get; set; }

        public Course() {

        }

        public Course(string name, string instructor, int credits, string major) {
            this.Name = name;
            this.Instructor = instructor;
            this.Credits = credits;
            var context = new AppDbContext();
            this.MajorId = context.Majors.SingleOrDefault(m => m.Description == major) == null
                ? null
                : (int?)context.Majors.SingleOrDefault(m => m.Description == major).Id;
        }
    }
}
