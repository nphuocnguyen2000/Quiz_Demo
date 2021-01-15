namespace DemoQuiz.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Result")]
    public partial class Result
    {
        public int ResultID { get; set; }

        [Required]
        [StringLength(10)]
        public string AccountID { get; set; }

        public int ExamID { get; set; }

        public DateTime? DateExam { get; set; }

        public double? Scores { get; set; }

        public int? TotalTimeDone { get; set; }

        public virtual Account Account { get; set; }

        public virtual Exam Exam { get; set; }
    }
}
