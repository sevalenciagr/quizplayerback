namespace QuizPlayer.Domain.Interfaces.Repositories
{
    using QuizPlayer.Domain.Entities;
    using System.Collections.Generic;

    public interface IAnswerRepository : IBaseRepository<Answer>
    {
        List<Answer> GetAnswersByQuestion(int idQuestion);
    }
}
