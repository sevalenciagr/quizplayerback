namespace QuizPlayer.Domain.Entities.Responses
{
    using Newtonsoft.Json;
    using QuizPlayer.Domain.Entities;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericResponse<T>: GenericResponse
    {
        /// <summary>
        /// Gets or sets the entity.
        /// </summary>
        /// <value>
        /// The entity.
        /// </value>
        public T Entity { get; set; }
    }
}
