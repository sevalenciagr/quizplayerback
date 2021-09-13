namespace QuizPlayer.Infra.Data.Repositories
{
    using global::Dapper;
    using global::Dapper.Contrib.Extensions;
    using Newtonsoft.Json;
    using QuizPlayer.Domain.Interfaces.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Reflection;
    using System.Threading.Tasks;
    using QuizPlayer.Domain.Entities;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="QuizPlayer.Domain.Interfaces.Repositories.IQueryRepository{T}" />
    public class QueryRepository<T>: IQueryRepository<T> where T: BaseEntity
    {
        /// <summary>
        /// The db factory.
        /// </summary>
        protected readonly IDbFactory DbFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRepository{T}"/> class.
        /// </summary>
        /// <param name="dbFactory">The database factory.</param>
        public QueryRepository(IDbFactory dbFactory)
        {
            this.DbFactory = dbFactory;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public virtual IEnumerable<T> GetQueryData(string sql, object param)
        {
            IEnumerable<T> entity;
            using (var db = this.DbFactory.GetConnection())
            {
                entity = db.Query<T>(sql, param);
            }
            return entity;
        }

        public virtual IEnumerable<T> GetQueryData(string sql)
        {
            IEnumerable<T> entity;
            using (var db = this.DbFactory.GetConnection())
            {
                entity = db.Query<T>(sql);
            }
            return entity;
        }
    }
}
