using QuizPlayer.Domain.Entities;

namespace QuizPlayer.Domain.Services.Utilities
{
    public static class Helper
    {
        public static GenericResponse ManageResponse(object data = null, bool status = true)
        {
            return new GenericResponse { Success = status, Data = data };
        }
    }
}