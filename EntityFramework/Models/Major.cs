using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFramework.Models {
    public class Major {
        public int Id { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Invalid Description: Description must be less than 30 characters")]
        public string Description { get; set; }
        [Required]
        public int MinSat { get; set; }

        public Major() {

        }
        public Major (int id, string description, int minsat) {
            this.Id = id;
            this.Description = description;
            this.MinSat = minsat;
        }
        public override string ToString() {
            return $"Major: {this.Id} {this.Description} has a requirment of a SAT of: {this.MinSat}";
        }
    }
}
