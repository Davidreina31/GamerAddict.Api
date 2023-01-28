using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamerAddict.Domain.Entity
{
	public class Question
	{
        public int Id { get; set; }

        public string QuestionText { get; set; }

        public DateTime QuestionDate { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; }

        [ForeignKey("VideoGame")]
        public int VideoGameId { get; set; }

        public VideoGame VideoGame { get; set; }

        public ICollection<Answer> Answers { get; set; }
    }
}

