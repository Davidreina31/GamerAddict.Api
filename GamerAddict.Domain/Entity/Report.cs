using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamerAddict.Domain.Entity
{
	public class Report
	{
        public int Id { get; set; }

        public string Reason { get; set; }

        public DateTime ReportDate { get; set; }

        [ForeignKey("Comment")]
        public int CommentId { get; set; }

        public Comment Comment { get; set; }

        [ForeignKey("User")]
        public int ReporterUserId { get; set; }

        public User ReporterUser { get; set; }
    }
}

