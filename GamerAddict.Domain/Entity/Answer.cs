using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamerAddict.Domain.Entity
{
	public class Answer
	{
        public int Id { get; set; }

        public string AnswerText { get; set; }

        public DateTime AnswerDate { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; }

        [ForeignKey("Question")]
        public int QuestionId { get; set; }

        public Question Question { get; set; }
    }
}

