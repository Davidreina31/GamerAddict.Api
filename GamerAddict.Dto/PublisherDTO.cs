using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamerAddict.Dto
{
	public class PublisherDTO
	{
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }

        public CityDTO? City { get; set; }

        public ICollection<VideoGameDTO>? VideoGames { get; set; }
    }
}

