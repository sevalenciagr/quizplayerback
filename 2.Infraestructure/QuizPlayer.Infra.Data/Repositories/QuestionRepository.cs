namespace QuizPlayer.Infra.Data.Repositories
{
    using QuizPlayer.Domain.Entities;
    using QuizPlayer.Domain.Interfaces.Repositories;
    using System.Collections.Generic;
    using System.Linq;
    using Dapper;

    public class QuestionRepository : BaseRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(IDbFactory dbFactory) : base(dbFactory) {        
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public List<Question> GetQuestionsByCategory(int idCategory)
        {
            var query = "SELECT * FROM [dbo].[question] WHERE idCategory = @idCategory";
            return base.GetQueryData(query, new { idCategory = idCategory })?.ToList();
        }
    }
}
