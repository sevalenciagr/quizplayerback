namespace QuizPlayer.Infra.Data.Repositories
{
    using QuizPlayer.Domain.Entities;
    using QuizPlayer.Domain.Interfaces.Repositories;
    using System.Collections.Generic;
    using System.Linq;
    using Dapper;


    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(IDbFactory dbFactory) : base(dbFactory) {        
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Category> GetCategoryAll()
        {
            var query = "SELECT * FROM [dbo].[category]";
            return base.GetQueryData(query)?.ToList();
        }
    }
}
