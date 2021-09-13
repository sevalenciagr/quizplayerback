namespace QuizPlayer.Domain.Interfaces.Repositories
{
    using QuizPlayer.Domain.Entities;
    using System.Collections.Generic;

    public interface IQuestionRepository : IBaseRepository<Question>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idCategory"></param>
        /// <returns></returns>
        List<Question> GetQuestionsByCategory(int idCategory);
    }
}
