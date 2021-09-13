namespace QuizPlayer.Domain.Interfaces.Repositories
{
    using System.Collections.Generic;
    using QuizPlayer.Domain.Entities;

    public interface IPrizeRepository : IBaseRepository<Prize>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<Prize> GetPrizesAll();
    }
}
