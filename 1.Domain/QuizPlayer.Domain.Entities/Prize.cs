namespace QuizPlayer.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Dapper.Contrib.Extensions;

    [Table("prize")]
    public class Prize : BaseEntity
    {
        public string description { get; set; }

        public int? value { get; set; }

        public int? prizeType { get; set; }
    }
}
