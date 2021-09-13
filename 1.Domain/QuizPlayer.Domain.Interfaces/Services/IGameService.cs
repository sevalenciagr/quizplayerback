namespace QuizPlayer.Domain.Interfaces.Services
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using QuizPlayer.Domain.Entities;

    public interface IGameService : IBaseService<Game>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Game NewGame(Player player, List<Category> categories);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        long InsertGame(Game game);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="answerQuestion"></param>
        /// <returns></returns>
        AnswerQuestionDto AnswerQuestion(AnswerQuestionDto answerQuestion);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="game"></param>
        /// <param name="statusType"></param>
        void StopGame(Game game, bool statusType);
    }
}
