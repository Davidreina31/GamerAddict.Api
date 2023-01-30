using System;
namespace GamerAddict.Domain.Entity
{
	public class User
	{
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }

        public string Sub { get; set; }

        public ICollection<User_VideoGame> UserVideoGame { get; set; }
    }
}

