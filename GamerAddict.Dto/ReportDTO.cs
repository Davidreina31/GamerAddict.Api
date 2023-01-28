using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamerAddict.Dto
{
	public class ReportDTO
	{
        public int Id { get; set; }

        public string Reason { get; set; }

        public DateTime ReportDate { get; set; }

        [ForeignKey("Comment")]
        public int CommentId { get; set; }

        public CommentDTO? Comment { get; set; }

        [ForeignKey("User")]
        public int ReporterUserId { get; set; }

        public UserDTO? User { get; set; }
    }
}

