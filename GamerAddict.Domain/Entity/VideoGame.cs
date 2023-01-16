using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamerAddict.Domain.Entity
{
	public class VideoGame
	{
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }

        [ForeignKey("Developer")]
        public int DeveloperId { get; set; }

        public Developer Developer { get; set; }

        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }

        public Publisher Publisher { get; set; }

        public string JacketUrl { get; set; }

        public ICollection<User_VideoGame> UserVideoGame { get; set; }

        public ICollection<Plateform_VideoGame> PlateformVideoGame { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}

