using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAddedMessage = "Product Added!";
        public static string ProductAddedErrorMessage = "Something went wrong! Please Try Again.";
        public static string MaintenanceTime = "System is offline";
        public static string ProductListedMessage = "Products Listed!";
        public static string AuthDeniedError = "Authorization Error";

        public static string AccessTokenCreated = "Token Created";

        public static string UserAlreadyExists = "User Already Exists";
        public static string SuccessfulLogin = "Login Successfully";
        public static string PasswordError = "Password Error";
        public static string UserNotFound = "User Not Found";
        public static string UserRegistered = "User Registered";
    }
}
