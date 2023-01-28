using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamerAddict.Dto
{
	public class QuestionDTO
	{
        public int Id { get; set; }

        public string QuestionText { get; set; }

        public DateTime QuestionDate { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public UserDTO? User { get; set; }

        [ForeignKey("VideoGame")]
        public int VideoGameId { get; set; }

        public VideoGameDTO? VideoGame { get; set; }

        public ICollection<AnswerDTO>? Answers { get; set; }
    }
}

