using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AkitoRentals.Web.Mvc.Models.ViewModels
{
	public class CarAvailabilityViewModel
	{
		public int AvailabilityId { get; set; }

		public string AvailabilityTitle { get; set; }

		public List<Car> Cars { get; set; }
	}
}