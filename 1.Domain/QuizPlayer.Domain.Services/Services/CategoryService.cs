namespace QuizPlayer.Domain.Services.Services
{
    using Microsoft.Extensions.Options;
    using QuizPlayer.Domain.Entities;
    using QuizPlayer.Domain.Entities.Config;
    using QuizPlayer.Domain.Interfaces.Repositories;
    using QuizPlayer.Domain.Interfaces.Services;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly AppSettings appSettings;

       /// <summary>
       /// 
       /// </summary>
       /// <param name="categoryRepository"></param>
       /// <param name="appSettings"></param>
        public CategoryService(ICategoryRepository categoryRepository, IOptions<AppSettings> appSettings)
        {
            this.categoryRepository = categoryRepository;
            this.appSettings = appSettings.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Category> GetCategoryAll()
        {
            return this.categoryRepository.GetCategoryAll();
        }
    }
}
