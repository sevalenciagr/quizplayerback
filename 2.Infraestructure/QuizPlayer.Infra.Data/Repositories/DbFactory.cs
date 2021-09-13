namespace QuizPlayer.Infra.Data.Repositories
{
    using Microsoft.Extensions.Options;
    using QuizPlayer.Domain.Interfaces.Repositories;
    using System.Data;
    using System.Data.Common;
    using System.Data.SqlClient;
    using QuizPlayer.Domain.Entities.Config;

    public class DbFactory : IDbFactory
    {
        /// <summary>
        /// The string connection.
        /// </summary>
        private readonly string connectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="DbFactory"/> class.
        /// </summary>
        /// <param name="connectionString">
        /// The connection string.
        /// </param>
        public DbFactory(IOptions<AppSettings> appSettings)
        {
            this.connectionString = appSettings.Value.DefaultConnectionString;
        }

        /// <summary>
        /// The get connection.
        /// </summary>
        /// <returns>
        /// The <see cref="IDbConnection"/>.
        /// </returns>
        public IDbConnection GetConnection()
        {
            DbConnection sqlConnection = new SqlConnection(this.connectionString);
            var wrapConnection = new WrapDBConnection(sqlConnection);
            wrapConnection.Open();
            return wrapConnection;
        }
    }
}
