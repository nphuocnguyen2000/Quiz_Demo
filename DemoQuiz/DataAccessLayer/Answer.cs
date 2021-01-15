namespace DemoQuiz.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Answer")]
    public partial class Answer
    {
        public int AnswerID { get; set; }

        public int? QuizID { get; set; }

        [StringLength(100)]
        public string ContentAnswer { get; set; }

        [StringLength(1)]
        public string Correct { get; set; }

        public virtual Quiz Quiz { get; set; }
    }
}
