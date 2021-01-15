namespace DemoQuiz.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Quiz")]
    public partial class Quiz
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Quiz()
        {
            Answers = new HashSet<Answer>();
        }

        public int QuizID { get; set; }

        [StringLength(300)]
        public string QuizName { get; set; }

        [StringLength(10)]
        public string SubjectID { get; set; }

        [StringLength(1)]
        public string Level { get; set; }

        public int? ExamID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Answer> Answers { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
