namespace DemoQuiz.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            Results = new HashSet<Result>();
            Exams = new HashSet<Exam>();
        }

        [StringLength(10)]
        public string AccountID { get; set; }

        [StringLength(40)]
        public string FullName { get; set; }

        [StringLength(40)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public DateTime? BirthDay { get; set; }

        [StringLength(10)]
        public string Class { get; set; }

        [StringLength(10)]
        public string Faculty { get; set; }

        [StringLength(1)]
        public string role { get; set; }

        public virtual Faculty Faculty1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Result> Results { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exam> Exams { get; set; }

        public virtual Class Class1 { get; set; }
    }
}
