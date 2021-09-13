
namespace QuizPlayer.Application.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using QuizPlayer.Domain.Entities;
    using QuizPlayer.Domain.Entities.Responses;
    public interface IGameApplication
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        GenericResponse<Game> PlayGame(Player player);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="answerQuestion"></param>
        /// <returns></returns>
        GenericResponse<AnswerQuestionDto> AnswerQuestion(AnswerQuestionDto answerQuestion);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="answerQuestion"></param>
        /// <returns></returns>
        GenericResponse<AnswerQuestionDto> ChooseQuestion(AnswerQuestionDto answerQuestion);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="answerQuestion"></param>
        /// <returns></returns>
        GenericResponse<AnswerQuestionDto> StopGame(AnswerQuestionDto answerQuestion);
    }
}
