namespace QuizPlayer.Domain.Entities
{
    using Dapper.Contrib.Extensions;
    using System;
    using System.Collections.Generic;
    using System.Text;

    [Table("category")]
    public class Category: BaseEntity
    {
        public string name { get; set; }

        public int? level { get; set; }

        [Computed]
        public List<Question> questions { get; set; }
    }
}
