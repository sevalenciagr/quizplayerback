namespace QuizPlayer.Domain.Interfaces.Services
{
    using QuizPlayer.Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IQuestionService : IBaseService<Question>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idCategory"></param>
        /// <returns></returns>
        List<Question> GetQuestionsByCategory(int idCategory);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idCategory"></param>
        /// <param name="questionsPlayed"></param>
        /// <returns></returns>
        Question ChooseQuestion(int idCategory, List<Question> questionsPlayed);
    }
}
