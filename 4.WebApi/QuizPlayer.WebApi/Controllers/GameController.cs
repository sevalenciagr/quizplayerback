namespace QuizPlayer.WebApi.Controllers
{
    using QuizPlayer.Application.Interfaces;
    using QuizPlayer.Domain.Entities;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using QuizPlayer.Domain.Entities.Config;
    using Microsoft.Extensions.Options;

    [ApiController]
    public class GameController : Controller
    {
        private readonly IGameApplication gameApplication;
        
        public GameController(IGameApplication gameApplication)
        {
            this.gameApplication = gameApplication;
          
        }

        [HttpPost]
        [Route("quizplay/game/playgame")]
        public GenericResponse PlayGame(Player player)
        {
            return gameApplication.PlayGame(player);
        }

        [HttpPost]
        [Route("quizplay/game/choosequestion")]
        public GenericResponse ChooseQuestion(AnswerQuestionDto answerQuestion)
        {
            return gameApplication.ChooseQuestion(answerQuestion);
        }

        [HttpPost]
        [Route("quizplay/game/answerquestion")]
        public GenericResponse AnswerQuestion(AnswerQuestionDto answerQuestion)
        {
            return gameApplication.AnswerQuestion(answerQuestion);
        }

        [HttpPost]
        [Route("quizplay/game/stopgame")]
        public GenericResponse StopGame(AnswerQuestionDto answerQuestion)
        {
            return gameApplication.StopGame(answerQuestion);
        }

    }
}