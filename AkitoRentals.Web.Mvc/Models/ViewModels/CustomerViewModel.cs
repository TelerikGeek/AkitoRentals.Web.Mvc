using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AkitoRentals.Web.Mvc.Models.ViewModels
{
	public class CustomerViewModel
	{
		public int CustomerId { get; set; }

		public string Firstname { get; set; }

		public string Lastname { get; set; }

		public Nullable<DateTime> DateOfBirth { get; set; }

		public string CustIdentificationNo { get; set; }

		public int EmploymentStatusId { get; set; }

		public string EmploymentStatusTitle { get; set; }

		public string MobileNo { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public int CitizenshipId { get; set; }

		public string CitizenshipTitle { get; set; }

		public string StreetName { get; set; }

		public string BuildingName { get; set; }

		public string BuildingNo { get; set; }

		public string UnitNo { get; set; }

		public string PostalCode { get; set; }

		public Nullable<System.DateTime> DateCreated { get; set; }

		public Nullable<System.DateTime> DateModified { get; set; }

		public Nullable<int> StatusId { get; set; }

		public string CustomerStatusTitle { get; set; }

		public EmploymentStatus EmploymentStatus { get; set; }

		public Citizenship Citizenship { get; set; }

		public CustomerStatus CustomerStatus { get; set; }

		public List<RentalHistory> RentalHistories { get; set; }
	}
}