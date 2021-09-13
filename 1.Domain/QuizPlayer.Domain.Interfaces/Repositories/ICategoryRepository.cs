namespace QuizPlayer.Domain.Interfaces.Repositories
{
    using QuizPlayer.Domain.Entities;
    using System.Collections.Generic;

    public interface ICategoryRepository : IBaseRepository<Category>
    {
        List<Category> GetCategoryAll();
    }
}
