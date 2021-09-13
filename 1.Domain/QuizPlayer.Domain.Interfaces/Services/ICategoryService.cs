namespace QuizPlayer.Domain.Interfaces.Services
{
    using QuizPlayer.Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface ICategoryService : IBaseService<Category>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<Category> GetCategoryAll();
    }
}
