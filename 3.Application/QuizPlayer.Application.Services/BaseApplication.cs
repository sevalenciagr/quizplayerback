namespace QuizPlayer.Application.Services
{
    using QuizPlayer.Domain.Entities.Responses;
    using System.Threading.Tasks;
    using QuizPlayer.Application.Interfaces;
    using QuizPlayer.Domain.Interfaces.Services;
    using QuizPlayer.Domain.Services.Utilities;
    using QuizPlayer.Domain.Entities;

    public class BaseApplication<T> : IBaseApplication<T> where T : BaseEntity
    {
        private readonly IBaseService<T> baseService;

        public BaseApplication(IBaseService<T> baseService) {
            this.baseService = baseService;
        }

   
    }
}
