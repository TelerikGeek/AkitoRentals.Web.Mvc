using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AkitoRentals.Web.Mvc.Models.ViewModels
{
	public class EmployeeViewModel
	{
		public int EmployeeId { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public string Firstname { get; set; }

		public string Lastname { get; set; }

		public string EmployeeCode { get; set; }

		public int PositionId { get; set; }

		public string PositionTitle { get; set; }

		public string JobTitle { get; set; }

		public Nullable<DateTime> LastLogin { get; set; }

		public Nullable<DateTime> DateCreated { get; set; }

		public Nullable<DateTime> DateModified { get; set; }

		public Nullable<int> StatusId { get; set; }

		public string StatusTitle { get; set; }

		public EmployeePosition EmployeePosition { get; set; }

		public EmployeeStatus EmployeeStatus { get; set; }

		public List<RentalHistory> RentalHistories { get; set; }
	}
}