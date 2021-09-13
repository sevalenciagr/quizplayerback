namespace QuizPlayer.Domain.Services.Utilities
{
    using Newtonsoft.Json;
    using QuizPlayer.Domain.Entities;
    using QuizPlayer.Domain.Entities.Responses;

    public static class HelperGeneric<T>
    {
        /// <summary>
        /// Casts to generic response.
        /// </summary>
        /// <param name="parentObject">The parent object.</param>
        /// <returns></returns>
        public static GenericResponse<T> CastToGenericResponseSerialize(object parentObject)
        {
            var serializedParent = JsonConvert.SerializeObject(parentObject);
            GenericResponse<T> serializedChild = JsonConvert.DeserializeObject<GenericResponse<T>>(serializedParent);
            return serializedChild;
        }

        public static GenericResponse<T> CastToGenericResponse(GenericResponse parentObject)
        {
            GenericResponse<T> serializedChild = new GenericResponse<T>()
            {
                Success = parentObject.Success,
                Data = parentObject.Data
            };
            return serializedChild;
        }

    }
}
