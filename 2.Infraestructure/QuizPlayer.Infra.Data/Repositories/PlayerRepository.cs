namespace QuizPlayer.Infra.Data.Repositories
{
    using QuizPlayer.Domain.Entities;
    using QuizPlayer.Domain.Interfaces.Repositories;   
    using System.Linq;
    using Dapper;

    /// <summary>
    /// 
    /// </summary>
    public class PlayerRepository: BaseRepository<Player>, IPlayerRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbFactory"></param>
        public PlayerRepository(IDbFactory dbFactory) : base(dbFactory) {        
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public Player GetPlayerByCode(string code) {
            var query = "SELECT * FROM [dbo].[player] WHERE code = @code";
            return base.GetQueryData(query, new { code = code })?.FirstOrDefault();
        }

    }
}
