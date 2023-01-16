using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamerAddict.Domain.Entity
{
	public class Plateform_VideoGame
	{
        public int Id { get; set; }

        [ForeignKey("Plateform")]
        public int PlateformId { get; set; }

        public Plateform Plateform { get; set; }

        [ForeignKey("VideoGame")]
        public int VideoGameId { get; set; }

        public VideoGame VideoGame { get; set; }
    }
}

