using System;
using System.ComponentModel;

namespace MovieTicketApp
{
    public class User
    {
        public int Id { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string FullName { get; private set; }

        /* also need security level and username for datagrid */

        public User(int id, string firstName, string lastName, string email)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.FullName = $"{this.FirstName} {this.LastName}";
        }
    }
}
