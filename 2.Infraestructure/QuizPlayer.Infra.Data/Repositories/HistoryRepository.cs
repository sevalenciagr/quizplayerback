namespace QuizPlayer.Infra.Data.Repositories
{
    using QuizPlayer.Domain.Entities;
    using QuizPlayer.Domain.Interfaces.Repositories;

    public class HistoryRepository : BaseRepository<History>, IHistoryRepository
    {
        public HistoryRepository(IDbFactory dbFactory) : base(dbFactory) {        
        }
    }
}
