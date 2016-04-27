using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AkitoRentals.Web.Mvc.Models.ViewModels
{
	public class CarModelViewModel
	{
		public int ModelId { get; set; }

		public int MakeId { get; set; }

		public string MakeTitle { get; set; }

		public int ReleaseYear { get; set; }

		public string ModelName { get; set; }

		public string ModelNo { get; set; }

		public string ModelPhotoUrl { get; set; }

		public DateTime DateCreated { get; set; }

		public DateTime DateModified { get; set; }

		public CarMake CarMake { get; set; }

		public List<Car> Cars { get; set; }
	}
}