namespace QuizPlayer.Domain.Entities
{
    using Dapper.Contrib.Extensions;
    using System.Collections.Generic;

    [Table("game")]
    public class Game : BaseEntity
    {
        public int? level { get; set; }

        public int? countQuestion { get; set; }

        public bool? status { get; set; }

        public int? idPlayer { get; set; }

        public int? idQuestion { get; set; }

        [Computed]
        public Player player { get; set; }

        [Computed]
        public List<Category> categories { get; set; }

        [Computed]
        public List<Question> questionsPlayed { get; set; }

    }
}
