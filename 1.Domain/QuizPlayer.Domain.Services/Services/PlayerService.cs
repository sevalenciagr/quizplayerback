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

    public class PlayerService: IPlayerService
    {
        private readonly IPlayerRepository playerRepository;
        private readonly AppSettings appSettings;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="playerRepository"></param>
        /// <param name="appSettings"></param>
        public PlayerService(IPlayerRepository playerRepository, IOptions<AppSettings> appSettings)
        {
            this.playerRepository = playerRepository;
            this.appSettings = appSettings.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public Player GetPlayerByCode(string code) {
            return this.playerRepository.GetPlayerByCode(code);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public long InsertPlayer(Player player) {
            return this.playerRepository.Insert(player);
        }
    }
}
