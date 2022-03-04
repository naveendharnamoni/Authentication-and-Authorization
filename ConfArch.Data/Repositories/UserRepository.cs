using System.Collections.Generic;
using System.Linq;
using ConfArch.Data.Models;


namespace ConfArch.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<User> users = new List<User>
        {
            new User { Id = 3522, Name = "naveen", Password = "pbuYKcaZgo+nq/dWNW37usBM6lqQNGQ1KGA2yVP3xl8=",
                FavoriteColor = "blue", Role = "Admin", GoogleId = "100357306290504831908" }
        };

        public User GetByUsernameAndPassword(string username, string password)
        {
            var user = users.SingleOrDefault(u => u.Name == username &&
                u.Password == password.Sha256());
            return user;
        }

        public User GetByGoogleId(string googleId)
        {
            var user = users.SingleOrDefault(u => u.GoogleId == googleId);
            return user;
        }

    }
}
