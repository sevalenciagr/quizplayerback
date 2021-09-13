namespace QuizPlayer.Domain.Interfaces.Services
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using QuizPlayer.Domain.Entities;

    public interface IPrizeService : IBaseService<Prize>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<Prize> GetPrizesAll();
    }
}
