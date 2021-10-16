using System;
using GenericResponse;
namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User
            {
                Name = "Emre",
                Email = "junk@emreceyhan.com"
            };



            var userRegisterResponse = RegisterNewUser(user);


            if (!userRegisterResponse.Success)
            {
                Console.WriteLine($"Log error - {userRegisterResponse.Message}");
            }
            else
            {
                Console.WriteLine($"User {userRegisterResponse.GenericModel.Name} is successfully registered");
            }

        }


        public static GenericResponse<User> RegisterNewUser(User user)
        {
            Console.WriteLine($"Trying to register user {user.Name}");

           

            bool IsUserRegistered = false; //something bad happend when registering user

            switch (IsUserRegistered)
            {
                case true:
                    return new GenericResponse<User>(user);
                case false:
                    return new GenericResponse<User>("something happend when registering user");
            }

        }




        public static GenericResponse<User> FakeServiceSuccess(User user)
        {
            return new GenericResponse<User>(user);
        }

        public static GenericResponse<User> FakeServiceFail(User user)
        {
            return new GenericResponse<User>("Something happend");
        }



    }


    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
