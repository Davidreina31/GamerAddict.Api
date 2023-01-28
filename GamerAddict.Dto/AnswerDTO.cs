using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamerAddict.Dto
{
	public class AnswerDTO
	{
        public int Id { get; set; }

        public string AnswerText { get; set; }

        public DateTime AnswerDate { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public UserDTO? User { get; set; }

        [ForeignKey("Question")]
        public int QuestionId { get; set; }

        public QuestionDTO? Question { get; set; }
    }
}

