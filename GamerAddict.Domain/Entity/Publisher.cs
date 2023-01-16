using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamerAddict.Domain.Entity
{
	public class Publisher
	{
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }

        public City City { get; set; }

        public ICollection<VideoGame> VideoGames { get; set; }
    }
}

