namespace QuizPlayer.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using Dapper.Contrib.Extensions;
    using System.Text;

    [Table("answer")]
    public class Answer : BaseEntity
    {
        public string description { get; set; }

        public bool? status { get; set; }

        public int? idQuestion { get; set; }


    }
}
