namespace QuizPlayer.Domain.Interfaces.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using QuizPlayer.Domain.Entities;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="DataType">The type of the ata type.</typeparam>
    public interface IBaseService<T> where T : BaseEntity
    {
       
    }
}
