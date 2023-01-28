using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamerAddict.Dto
{
	public class CommentDTO
	{
        public int Id { get; set; }

        public int Note { get; set; }

        public string CommentText { get; set; }

        public DateTime CommentDate { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public UserDTO? User { get; set; }

        [ForeignKey("VideoGame")]
        public int VideoGameId { get; set; }

        public VideoGameDTO? VideoGame { get; set; }
    }
}

