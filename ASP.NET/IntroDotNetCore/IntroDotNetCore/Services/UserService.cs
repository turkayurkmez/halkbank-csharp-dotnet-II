using IntroDotNetCore.Models;

namespace IntroDotNetCore.Services
{
    public static class UserService
    {
        private static List<UserResponse> _users = new List<UserResponse>();
        public static void AddUserResponse(UserResponse response)
        {
            _users.Add(response);
        }

        public static List<UserResponse> GetUserResponses() => _users;


    }
}
