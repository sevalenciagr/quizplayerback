namespace QuizPlayer.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class AnswerQuestionDto
    {
        public Game game { get; set; }

        public Question question { get; set; }

        public Answer answer { get; set; }
    }
}
