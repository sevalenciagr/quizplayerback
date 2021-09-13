namespace QuizPlayer.Infra.Data.Repositories
{
    using System.Collections.Generic;
    using QuizPlayer.Domain.Entities;
    using QuizPlayer.Domain.Interfaces.Repositories;
    using System.Linq;
    using Dapper;

    public class AnswerRepository : BaseRepository<Answer>, IAnswerRepository
    {
        public AnswerRepository(IDbFactory dbFactory) : base(dbFactory) {        
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idQuestion"></param>
        /// <returns></returns>
        public List<Answer> GetAnswersByQuestion(int idQuestion)
        {
            var query = "SELECT * FROM [dbo].[answer] WHERE idQuestion = @idQuestion";
            return base.GetQueryData(query, new { idQuestion = idQuestion })?.ToList();
        }
    }
}
