
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamerAddict.Dto
{
	public class VideoGameDTO
	{
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }

        [ForeignKey("Developer")]
        public int DeveloperId { get; set; }

        public DeveloperDTO? Developer { get; set; }

        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }

        public PublisherDTO? Publisher { get; set; }

        public string JacketUrl { get; set; }

        public ICollection<User_VideoGameDTO>? UserVideoGame { get; set; }

        public ICollection<Plateform_VideoGameDTO>? PlateformVideoGame { get; set; }

        public ICollection<CommentDTO>? Comments { get; set; }
        public ICollection<QuestionDTO>? Questions { get; set; }
    }
}

