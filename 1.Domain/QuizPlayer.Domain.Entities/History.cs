namespace QuizPlayer.Domain.Entities
{
    using System;
    using Dapper.Contrib.Extensions;

    [Table("history")]
    public class History : BaseEntity
    {
        public DateTime? creationDate { get; set; }

        public int? idPlayer { get; set; }

        public int? idPrize { get; set; }
    }
}
