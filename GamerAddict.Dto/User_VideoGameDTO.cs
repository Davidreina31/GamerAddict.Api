using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamerAddict.Dto
{
	public class User_VideoGameDTO
	{
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public UserDTO User { get; set; }

        [ForeignKey("VideoGame")]
        public int VideoGameId { get; set; }

        public VideoGameDTO VideoGame { get; set; }
    }
}

