namespace QuizPlayer.Domain.Entities
{
    using Dapper.Contrib.Extensions;
    using System;
    using System.Collections.Generic;
    using System.Text;

    [Table("question")]
    public class Question : BaseEntity
    {
        public string description { get; set; }

        public int? idCategory { get; set; }

        [Computed]
        public List<Answer> answers { get; set; }
    }
}
