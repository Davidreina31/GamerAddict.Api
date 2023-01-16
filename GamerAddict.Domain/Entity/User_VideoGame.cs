using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamerAddict.Domain.Entity
{
	public class User_VideoGame
	{
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; }

        [ForeignKey("VideoGame")]
        public int VideoGameId { get; set; }

        public VideoGame VideoGame { get; set; }
    }
}

