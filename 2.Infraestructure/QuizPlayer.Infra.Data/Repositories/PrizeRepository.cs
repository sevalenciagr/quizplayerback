namespace QuizPlayer.Infra.Data.Repositories
{
    using System.Collections.Generic;
    using QuizPlayer.Domain.Entities;
    using QuizPlayer.Domain.Interfaces.Repositories;
    using System.Linq;
    using Dapper;

    public class PrizeRepository : BaseRepository<Prize>, IPrizeRepository
    {
        public PrizeRepository(IDbFactory dbFactory) : base(dbFactory) {        
        }

       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
        public List<Prize> GetPrizesAll()
        {
            var query = "SELECT * FROM [dbo].[prize]";
            return base.GetQueryData(query)?.ToList();
        }
    }
}
