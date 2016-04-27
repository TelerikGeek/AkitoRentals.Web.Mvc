using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using AkitoRentals.Web.Mvc.Models;
using System.Web;

namespace AkitoRentals.Web.Mvc.Models.ViewModels
{
	public class CarViewModel
	{
		public int CarId { get; set; }

		public String VehicleNo { get; set; }

		public String RentalCarCode { get; set; }

		public int TypeId { get; set; }

		public String TypeTitle { get; set; }

		public int ModelId { get; set; }

		public String ModelName { get; set; }

		public int MakeId { get; set; }

		public String MakeTitle { get; set; }

		public int? AvailabilityId { get; set; }

		public String AvailabilityTitle { get; set; }

		public int? YearsOfUse { get; set; }

		public int? MonthsOfUse { get; set; }

		public int? SeatingCapacity { get; set; }

		public String ExteriorPhotoUrl { get; set; }

		public String InteriorPhotoUrl { get; set; }

		public DateTime? DateCreated { get; set; }

		public DateTime? DateModified { get; set; }

		public int? StatusId { get; set; }

		public String StatusTitle { get; set; }

		public CarType CarType { get; set; }

		public CarModel CarModel { get; set; }

		public CarMake CarMake { get; set; }

		public CarAvailability CarAvailability { get; set; }

		public CarStatus CarStatus { get; set; }

		public List<CarMileage> CarMileages { get; set; }

		public List<RentalHistory> RentalHistories { get; set; }
	}
}