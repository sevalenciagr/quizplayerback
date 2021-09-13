namespace QuizPlayer.Domain.Services.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using QuizPlayer.Domain.Entities;
    using QuizPlayer.Domain.Interfaces.Repositories;
    using QuizPlayer.Domain.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="QuizPlayer.Domain.Interfaces.Interfaces.IBaseService{T}" />
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        private readonly IBaseRepository<T> baseRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseService{T}"/> class.
        /// </summary>
        /// <param name="baseRepository">The base repository.</param>
        public BaseService(IBaseRepository<T> baseRepository) {
            this.baseRepository = baseRepository;
        }


    }
}
