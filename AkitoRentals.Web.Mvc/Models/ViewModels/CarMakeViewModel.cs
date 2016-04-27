using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AkitoRentals.Web.Mvc.Models.ViewModels
{
	public class CarMakeViewModel
	{
		public int MakeId { get; set; }

		public int OriginId { get; set; }

		public string OriginTitle { get; set; }

		public string MakeTitle { get; set; }

		public string BrandLogoUrl { get; set; }

		public CarMakeOrigin CarMakeOrigin { get; set; }

		public List<CarModel> CarModels { get; set; }
	}
}