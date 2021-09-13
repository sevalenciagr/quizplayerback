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

    public class AnswerService : IAnswerService
    {
        private readonly IAnswerRepository answerRepository;
        private readonly AppSettings appSettings;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="playerRepository"></param>
        /// <param name="appSettings"></param>
        public AnswerService(IAnswerRepository answerRepository, IOptions<AppSettings> appSettings)
        {
            this.answerRepository = answerRepository;
            this.appSettings = appSettings.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idQuestion"></param>
        /// <returns></returns>
        public List<Answer> GetAnswersByQuestion(int idQuestion)
        {
            return this.answerRepository.GetAnswersByQuestion(idQuestion);
        }
    }
}
