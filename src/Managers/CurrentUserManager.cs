using System;

namespace MovieTicketApp
{
    public class CurrentUserManager
    {
        /*
         * This class is supposed to act as a singleton, meaning that there will only be a single instance
         * of it throughout the app
         * 
         */
        public User CurrentUser { get; private set; }
        private static CurrentUserManager _instance;

        private CurrentUserManager() { }

        /*
         * This is a singleton property that allows access to the instance of the class itself,
         * not to be confused as a method
         */
        public static CurrentUserManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CurrentUserManager();
                }
                return _instance;
            }
        }

        // The current user is set on Form_Login, assuming that the login is successful
        public void SetCurrentUser(User user)
        {
            CurrentUser = user;
        }
    }
}
