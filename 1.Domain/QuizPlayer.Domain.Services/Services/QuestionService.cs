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


    public class QuestionService: IQuestionService
    {
        private readonly IQuestionRepository questionRepository;
        private readonly AppSettings appSettings;

        public QuestionService(IQuestionRepository questionRepository, IOptions<AppSettings> appSettings)
        {
            this.questionRepository = questionRepository;
            this.appSettings = appSettings.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Question> GetQuestionsByCategory(int idCategory)
        {
            return this.questionRepository.GetQuestionsByCategory(idCategory);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Question ChooseQuestion(int idCategory, List<Question> questionsPlayed)
        {           
            bool band = true;
            Random rnd = new Random();
            Question question = null;
            var questions = this.GetQuestionsByCategory(idCategory);
            while (band) {
                question= questions[rnd.Next(0, questions.Count)];
                if (!questionsPlayed.Contains(question)) {
                    band = false;
                }                
            }
            questionsPlayed.Add(question);
            return question;
        }
    }
}
