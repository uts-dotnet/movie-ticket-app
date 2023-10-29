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
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public UserData(int userId, string username, string password, string firstName, string lastName)
        {
            UserId = userId;
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
        }

        // Must use this method to create movies or else it won't increment ID or add to global
        public static UserData CreateNewUser(string username, string password, string firstName, string lastName)
        {
            int newUserId = GenerateNewUserDataId();
            UserData user = new UserData(newUserId, username, password, firstName, lastName);
            GlobalData.UserData.Add(user);
            return user;
        }

        private static int GenerateNewUserDataId()
        {
            int maxId = GlobalData.UserData.Max(u => u.UserId); // Find the maximum Id among existing UserData
            return maxId + 1;
        }

        public override string ToString()
        {
            return $"User ID: {UserId}, Username: {Username}, First Name: {FirstName}, Last Name: {LastName}";
        }

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
