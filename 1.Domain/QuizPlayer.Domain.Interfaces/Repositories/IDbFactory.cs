namespace QuizPlayer.Domain.Interfaces.Repositories
{
    using System.Data;

    public interface IDbFactory
    {
        /// <summary>
        /// The get connection.
        /// </summary>
        /// <returns>
        /// The <see cref="IDbConnection"/>.
        /// </returns>
        IDbConnection GetConnection();
    }
}
