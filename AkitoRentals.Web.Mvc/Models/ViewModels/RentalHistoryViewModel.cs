using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AkitoRentals.Web.Mvc.Models.ViewModels
{
	public class RentalHistoryViewModel
	{
		public int RentalHistoryId { get; set; }

		public int CustomerId { get; set; }

		public string CustFirstname { get; set; }

		public string CustLastname { get; set; }

		public int CarId { get; set; }

		public string VehicleNo { get; set; }

		public string RentalCarCode { get; set; }

		public Nullable<System.DateTime> RentalStartDate { get; set; }

		public Nullable<System.DateTime> RentalReturnDate { get; set; }

		public Nullable<decimal> RentalRate { get; set; }

		public int RentalMethodId { get; set; }

		public string RentalMethodTitle { get; set; }

		public int IssuingEmployeeId { get; set; }

		public string EmpFirstname { get; set; }

		public string EmpLastname { get; set; }

		public string EmployeeCode { get; set; }

		public Nullable<System.DateTime> DateCreated { get; set; }

		public Nullable<System.DateTime> DateModified { get; set; }

		public Nullable<bool> SendReminderAlert { get; set; }

		public Nullable<int> StatusId { get; set; }

		public string RentalStatusTitle { get; set; }

		public Customer Customer { get; set; }

		public Employee IssuingEmployee { get; set; }

		public RentalMethod RentalMethod { get; set; }

		public RentalStatus RentalStatus { get; set; }

		public Car Car { get; set; }
	}
}