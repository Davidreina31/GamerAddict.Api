using System;
namespace GamerAddict.Dto
{
	public class PlateformDTO
	{
        public int Id { get; set; }

        public string PlateformName { get; set; }

        public ICollection<Plateform_VideoGameDTO> PlateformVideoGame { get; set; }
    }
}

