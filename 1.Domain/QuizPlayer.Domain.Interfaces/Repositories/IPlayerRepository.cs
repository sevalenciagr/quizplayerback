namespace QuizPlayer.Domain.Interfaces.Repositories
{
    using QuizPlayer.Domain.Entities;

    /// <summary>
    /// 
    /// </summary>
    public interface IPlayerRepository: IBaseRepository<Player>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        Player GetPlayerByCode(string code);
    }
}
