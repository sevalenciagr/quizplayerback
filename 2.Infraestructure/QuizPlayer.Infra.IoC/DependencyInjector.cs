using QuizPlayer.Application.Interfaces;
using QuizPlayer.Application.Services;
using QuizPlayer.Domain.Interfaces.Repositories;
using QuizPlayer.Domain.Interfaces.Services;
using QuizPlayer.Domain.Services.Services;
using QuizPlayer.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using QuizPlayerApplication.Services;

namespace QuizPlayer.Infra.IoC
{
    public class DependencyInjector
    {
        public DependencyInjector()
        {
        }

        public IServiceCollection GetServiceCollection()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<IDbFactory, DbFactory>();
            services.AddSingleton(typeof(IQueryRepository<>), typeof(QueryRepository<>));
            services.AddSingleton(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            services.AddSingleton<IAnswerRepository, AnswerRepository>();
            services.AddSingleton<ICategoryRepository, CategoryRepository>();
            services.AddSingleton<IGameRepository, GameRepository>();
            services.AddSingleton<IHistoryRepository, HistoryRepository>();
            services.AddSingleton<IPlayerRepository, PlayerRepository>();
            services.AddSingleton<IPrizeRepository, PrizeRepository>();
            services.AddSingleton<IQuestionRepository, QuestionRepository>();

            services.AddSingleton(typeof(IBaseService<>), typeof(BaseService<>));

            services.AddSingleton<IAnswerService, AnswerService>();
            services.AddSingleton<ICategoryService, CategoryService>();
            services.AddSingleton<IGameService, GameService>();
            services.AddSingleton<IPlayerService, PlayerService>();
            services.AddSingleton<IPrizeService, PrizeService>();
            services.AddSingleton<IQuestionService, QuestionService>();
           
            services.AddSingleton<IGameApplication, GameApplication>();

            return services;
        }
    }
}