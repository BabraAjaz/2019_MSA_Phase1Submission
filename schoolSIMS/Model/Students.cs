using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace schoolSIMS.Model
{
    [Table("students")]
    public partial class Students
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("first_name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Column("last_name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Column("phone_number")]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        [Column("email")]
        [StringLength(50)]
        public string Email { get; set; }
        [Column("dob", TypeName = "date")]
        public DateTime? Dob { get; set; }
        [Column("date_created", TypeName = "date")]
        public DateTime? DateCreated { get; set; }
        [Column("programme_studying")]
        [StringLength(100)]
        public string ProgrammeStudying { get; set; }
        [Column("major")]
        [StringLength(50)]
        public string Major { get; set; }
        [Column("ethnicity")]
        [StringLength(50)]
        public string Ethnicity { get; set; }
        [Column("emergency_contact_name")]
        [StringLength(50)]
        public string EmergencyContactName { get; set; }
        [Column("emergency_contact_number")]
        [StringLength(50)]
        public string EmergencyContactNumber { get; set; }
    }
}
