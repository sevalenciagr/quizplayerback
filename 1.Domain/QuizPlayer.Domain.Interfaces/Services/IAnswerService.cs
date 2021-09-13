namespace QuizPlayer.Domain.Interfaces.Services
{
    using QuizPlayer.Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IAnswerService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idQuestion"></param>
        List<Answer> GetAnswersByQuestion(int idQuestion);
    }
}
