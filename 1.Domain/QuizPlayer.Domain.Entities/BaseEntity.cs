namespace QuizPlayer.Domain.Entities
{
    using Dapper.Contrib.Extensions;

    public class BaseEntity
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [Key]
        public virtual int id { get; set; } 
    }
}
