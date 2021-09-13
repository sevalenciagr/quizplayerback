namespace QuizPlayer.Domain.Entities
{
    using Dapper.Contrib.Extensions;
    using System;
    using System.Collections.Generic;
    using System.Text;

    [Table("player")]
    public class Player : BaseEntity
    {
        public string name { get; set; }

        public string code { get; set; }

        public int? point { get; set; }

        public bool? status { get; set; }

        [Computed]
        public List<History> histories { get; set; }
    }
}
