using System;
namespace GamerAddict.Dto
{
	public class UserDTO
	{
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        public string Sub { get; set; }

        public ICollection<User_VideoGameDTO>? UserVideoGame { get; set; }
    }
}

