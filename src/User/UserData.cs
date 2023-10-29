using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTicketApp.src.Managers;

namespace MovieTicketApp.src.User
{
    public class UserData
    {
        public int UserId { get; set; }       // Unique identifier for the user
        public string Username { get; set; }  // Username of the user
        public string Password { get; set; }  // Password of the user
        public string FirstName { get; set; } // First name of the user
        public string LastName { get; set; }  // Last name of the user

        // Constructor to initialize user data with provided details
        public UserData(int userId, string username, string password, string firstName, string lastName)
        {
            UserId = userId;
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
        }

        // Method to create a new user instance and add it to the global list
        public static UserData CreateNewUser(string username, string password, string firstName, string lastName)
        {
            int newUserId = GenerateNewUserDataId();
            UserData user = new UserData(newUserId, username, password, firstName, lastName);
            GlobalData.UserData.Add(user);
            return user;
        }

        // Generate a new unique user data ID based on existing IDs
        private static int GenerateNewUserDataId()
        {
            int maxId = GlobalData.UserData.Max(u => u.UserId); // Find the maximum Id among existing UserData
            return maxId + 1;
        }

        // Override the ToString method to provide a user-friendly string representation
        public override string ToString()
        {
            return $"User ID: {UserId}, Username: {Username}, First Name: {FirstName}, Last Name: {LastName}";
        }

        // Method to change the password of a user with a specified user ID
        public static bool ChangePassword(int userID, string newPassword)
        {
            UserData? user = GlobalData.UserData.FirstOrDefault(u => u.UserId == userID);

            if (user != null)
            {
                // Update the user's password
                user.Password = newPassword;

                // Save the updated user information (e.g., in your database)
                bool success = ChangePasswordInFile(user.Username, newPassword);

                if (success)
                {
                    return true; // Password changed successfully
                }
            }

            return false; // User not found
        }

        // Method to change a user's password in a file (e.g., a credentials file)
        public static bool ChangePasswordInFile(string username, string newPassword)
        {
            string filePath = "login-credentials.txt";
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');

                if (parts.Length >= 2 && parts[0] == username)
                {
                    // Update the password
                    parts[1] = newPassword;

                    // Reconstruct the line with updated password
                    lines[i] = string.Join(",", parts);
                    File.WriteAllLines(filePath, lines);

                    return true; // Password changed successfully
                }
            }

            return false; // User not found
        }
    }

}
