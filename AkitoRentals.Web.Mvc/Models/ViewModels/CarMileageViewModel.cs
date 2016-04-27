using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkitoRentals.Web.Mvc.Models.ViewModels
{
	public class CarMileageViewModel
	{
		public int MileageId { get; set; }

		public int CarId { get; set; }

		public decimal? DistanceTraveled { get; set; }

		public int? UsageMonth { get; set; }

		public int? UsageYear { get; set; }

		public DateTime? DateCreated { get; set; }

		public Car Car { get; set; }
	}
}
