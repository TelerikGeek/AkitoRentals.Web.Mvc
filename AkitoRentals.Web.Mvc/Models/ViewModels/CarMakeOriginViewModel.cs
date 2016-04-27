using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AkitoRentals.Web.Mvc.Models.ViewModels
{
	public class CarMakeOriginViewModel
	{
		public int OriginId { get; set; }

		public string OriginTitle { get; set; }

		public List<CarMake> CarMakes { get; set; }
	}
}