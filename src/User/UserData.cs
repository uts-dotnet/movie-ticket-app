using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTicketApp.src.Managers;

namespace MovieTicketApp.src.User
{
    [Serializable]

    public class UserData
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public UserData(int userId, string username, string password, string firstName, string lastName)
        {
            UserId = GenerateNewUserDataId();
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
        }

        private int GenerateNewUserDataId()
        {
            int maxId = GlobalData.UserData.Max(u => u.UserId); // Find the maximum Id among existing UserData
            return maxId + 1;
        }

        public override string ToString()
        {
            return $"User ID: {UserId}, Username: {Username}, First Name: {FirstName}, Last Name: {LastName}";
        }
    }

}
