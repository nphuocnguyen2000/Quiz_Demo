namespace DemoQuiz.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Exam")]
    public partial class Exam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exam()
        {
            Results = new HashSet<Result>();
        }

        public int ExamID { get; set; }

        [Required]
        [StringLength(10)]
        public string SubjectID { get; set; }

        [StringLength(20)]
        public string ExamName { get; set; }

        [StringLength(10)]
        public string AccountID { get; set; }

        public int? TimeTotal { get; set; }

        public int? TotalQuiz { get; set; }

        public int? PercentEasyQuiz { get; set; }

        public int? PercentHardQuiz { get; set; }

        [StringLength(20)]
        public string ExamPass { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateCreate { get; set; }

        public virtual Account Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Result> Results { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
