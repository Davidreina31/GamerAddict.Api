using System;
namespace GamerAddict.Domain.Entity
{
	public class Plateform
	{
        public int Id { get; set; }

        public string PlateformName { get; set; }

        public ICollection<Plateform_VideoGame> PlateformVideoGame { get; set; }
    }
}

