using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamerAddict.Dto
{
	public class Plateform_VideoGameDTO
	{
        public int Id { get; set; }

        [ForeignKey("Plateform")]
        public int PlateformId { get; set; }

        public PlateformDTO Plateform { get; set; }

        [ForeignKey("VideoGame")]
        public int VideoGameId { get; set; }

        public VideoGameDTO VideoGame { get; set; }
    }
}

