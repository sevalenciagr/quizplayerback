namespace QuizPlayer.Domain.Interfaces.Repositories
{
    using System.Collections.Generic;
    using QuizPlayer.Domain.Entities;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IQueryRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        IEnumerable<T> GetQueryData(string sql, object param);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        IEnumerable<T> GetQueryData(string sql);
    }
}
