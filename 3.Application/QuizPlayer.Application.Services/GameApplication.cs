namespace QuizPlayerApplication.Services
{
    using Microsoft.Extensions.Options;
    using System.Threading.Tasks;
    using QuizPlayer.Application.Interfaces;
    using QuizPlayer.Application.Services;
    using QuizPlayer.Domain.Entities;
    using QuizPlayer.Domain.Entities.Config;
    using QuizPlayer.Domain.Entities.Responses;
    using QuizPlayer.Domain.Interfaces.Services;
    using QuizPlayer.Domain.Services.Utilities;
    using System.Linq;
    using System.Collections.Generic;

    public class GameApplication : BaseApplication<Game>, IGameApplication
    {
        private readonly IGameService gameService;
        private readonly AppSettings appSettings;
        private readonly IQuestionService questionService;
        private readonly ICategoryService categoryService;
        private readonly IAnswerService answerService;

        /// <summary>
        /// Initializes a new instance of the <see cref="GameApplication"/> class.
        /// </summary>
        /// <param name="baseService">The base service.</param>
        /// <param name="gameService">The attention channel service.</param>
        public GameApplication(IBaseService<Game> baseService,IGameService gameService, 
            IQuestionService questionService,
            ICategoryService categoryService,
            IAnswerService answerService,
        IOptions<AppSettings> appSettings) : base(baseService)
        {
            this.gameService = gameService;
            this.questionService = questionService;
            this.answerService = answerService;
            this.categoryService = categoryService;
            this.appSettings = appSettings.Value;
        }

        /// <summary>
        /// Executes the insert procedure.
        /// </summary>
        /// <param name="procedure">The procedure.</param>
        /// <param name="myObject">My object.</param>
        /// <returns></returns>
        public GenericResponse<Game> PlayGame(Player player)
        {
            var categories = this.categoryService.GetCategoryAll();
            var game = this.gameService.NewGame(player, categories);
            Question questionAux = questionService.ChooseQuestion(game.level.Value, game.questionsPlayed);
            questionAux.answers = this.answerService.GetAnswersByQuestion(questionAux.id);
            game.idQuestion = questionAux.id;
            this.gameService.InsertGame(game);
            return  HelperGeneric<Game>.CastToGenericResponse(Helper.ManageResponse(game));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="answerQuestion"></param>
        /// <returns></returns>
        public GenericResponse<AnswerQuestionDto> AnswerQuestion(AnswerQuestionDto answerQuestion)
        {           
            this.gameService.AnswerQuestion(answerQuestion);
            return HelperGeneric<AnswerQuestionDto>.CastToGenericResponse(Helper.ManageResponse(answerQuestion));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="answerQuestion"></param>
        /// <returns></returns>
        public GenericResponse<AnswerQuestionDto> ChooseQuestion(AnswerQuestionDto answerQuestion)
        {
            Question questionAux = this.questionService.ChooseQuestion(answerQuestion.game.level.Value, answerQuestion.game.questionsPlayed);
            questionAux.answers = this.answerService.GetAnswersByQuestion(questionAux.id);
            return HelperGeneric<AnswerQuestionDto>.CastToGenericResponse(Helper.ManageResponse(answerQuestion));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="answerQuestion"></param>
        /// <returns></returns>
        public GenericResponse<AnswerQuestionDto> StopGame(AnswerQuestionDto answerQuestion)
        {
            this.gameService.StopGame(answerQuestion.game, false);
            return HelperGeneric<AnswerQuestionDto>.CastToGenericResponse(Helper.ManageResponse(answerQuestion));
        }
    }
}

