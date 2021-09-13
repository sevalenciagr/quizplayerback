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
    using System.Linq;

    public class GameService : IGameService
    {
        private readonly IGameRepository gameRepository;
        private readonly AppSettings appSettings;
        private readonly IPrizeService prizeService;

       /// <summary>
       /// 
       /// </summary>
       /// <param name="gameRepository"></param>
       /// <param name="appSettings"></param>
       /// <param name="prizeService"></param>
        public GameService(IGameRepository gameRepository, IOptions<AppSettings> appSettings, IPrizeService prizeService)
        {
            this.gameRepository = gameRepository;
            this.prizeService = prizeService;
            this.appSettings = appSettings.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Game NewGame(Player player, List<Category> categories)
        {
            var game = new Game()
            {
                status = true,
                player = player,
                idPlayer = player.id,
                countQuestion = 0,
                categories = categories.OrderBy(x => x.level)?.ToList(),
                questionsPlayed = new List<Question>()
            };
            game.level = game.categories.Select(x => x.level.Value).Min();
            return game;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public long InsertGame(Game game)
        {
            return this.gameRepository.Insert(game);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="answerQuestion"></param>
        public AnswerQuestionDto AnswerQuestion(AnswerQuestionDto answerQuestion)
        {
            if (answerQuestion.answer.status.Value)
            {
                answerQuestion.game.countQuestion++;
                if (answerQuestion.game.countQuestion > 4)
                {
                    answerQuestion.game.level = this.NextLevel(answerQuestion.game);
                    if (answerQuestion.game.level == answerQuestion.game.categories.LastOrDefault().level && answerQuestion.game.countQuestion > 3)
                    {
                        this.StopGame(answerQuestion.game, true);
                    }
                    this.AddHistory(answerQuestion.game, true);
                    answerQuestion.game.countQuestion = 0;
                }
            }
            else
            {
                this.StopGame(answerQuestion.game, false);
            }
            return answerQuestion;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="game"></param>
        /// <param name="statusType"></param>
        public void StopGame(Game game, bool statusType)
        {
            this.AddHistory(game, statusType);
            game.status = false;
            this.gameRepository.Update(game);
        }

        private Prize ChoosePrize()
        {
            var prizes = this.prizeService.GetPrizesAll();
            Random rnd = new Random();
            return prizes[rnd.Next(0, prizes.Count)];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        private int NextLevel(Game game)
        {
            var i = game.categories.FindIndex(x => x.level == game.level);
            var category = game.categories.ElementAt(i + 1);
            return category.level.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="game"></param>
        /// <param name="prizeType"></param>
        private void AddHistory(Game game, bool prizeType) {

            var history = new History()
            {
                idPlayer = game.player.id,                
                creationDate = DateTime.Now,
            };
            
            if (prizeType) {
                var prize = this.ChoosePrize();
                history.idPrize = prize.id;
            }
            game.player.histories.Add(history);
        }

    }
}
