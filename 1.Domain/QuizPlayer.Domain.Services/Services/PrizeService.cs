namespace QuizPlayer.Domain.Services.Services
{
    using Microsoft.Extensions.Options;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using QuizPlayer.Domain.Entities;
    using QuizPlayer.Domain.Entities.Config;
    using QuizPlayer.Domain.Interfaces.Repositories;
    using QuizPlayer.Domain.Interfaces.Services;

    public class PrizeService : IPrizeService
    {
        private readonly IPrizeRepository prizeRepository;
        private readonly AppSettings appSettings;

        public PrizeService(IPrizeRepository prizeRepository, IOptions<AppSettings> appSettings)
        {
            this.prizeRepository = prizeRepository;
            this.appSettings = appSettings.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Prize> GetPrizesAll()
        {
            return this.prizeRepository.GetPrizesAll();
        }

    }
}
