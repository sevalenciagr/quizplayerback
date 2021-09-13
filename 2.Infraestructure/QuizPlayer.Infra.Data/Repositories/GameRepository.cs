namespace QuizPlayer.Infra.Data.Repositories
{
    using QuizPlayer.Domain.Entities;
    using QuizPlayer.Domain.Interfaces.Repositories;

    public class GameRepository : BaseRepository<Game>, IGameRepository
    {
        public GameRepository(IDbFactory dbFactory) : base(dbFactory) {        
        }
    }
}
