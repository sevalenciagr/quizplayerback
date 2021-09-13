namespace QuizPlayer.Domain.Interfaces.Services
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using QuizPlayer.Domain.Entities;

    public interface IPlayerService : IBaseService<Player>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        Player GetPlayerByCode(string code);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        long InsertPlayer(Player player);
    }
}
