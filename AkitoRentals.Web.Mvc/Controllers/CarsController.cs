using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using AkitoRentals.Web.Mvc.Models;
using AkitoRentals.Web.Mvc.Models.ViewModels;

namespace AkitoRentals.Web.Mvc.Controllers
{
    public class CarsController : Controller
    {
		readonly AkitoRentalsContext context = new AkitoRentalsContext ( );

        // GET: Cars
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult List()
		{
			var carResults = from car in context.Cars
							 join type in context.CarTypes on car.TypeId equals type.TypeId
							 join model in context.CarModels on car.ModelId equals model.ModelId
							 join make in context.CarMakes on car.MakeId equals make.MakeId
							 join status in context.CarStatus on car.StatusId equals status.StatusId
							 join availability in context.CarAvailabilities on car.AvailabilityId equals availability.AvailabilityId
							 select new CarViewModel
							 {
								 CarId = car.CarId,
								 RentalCarCode = car.RentalCarCode,
								 TypeId = car.TypeId,
								 TypeTitle = car.CarType.TypeTitle,
								 ModelId = car.ModelId,
								 ModelName = car.CarModel.ModelName,
								 MakeId = car.MakeId,
								 MakeTitle = model.CarMake.MakeTitle,
								 AvailabilityId = car.AvailabilityId,
								 AvailabilityTitle = car.CarAvailability.AvailabilityTitle,
								 YearsOfUse = car.YearsOfUse,
								 MonthsOfUse = car.MonthsOfUse,
								 SeatingCapacity = car.SeatingCapacity,
								 DateCreated = car.DateCreated,
								 DateModified = car.DateModified,
								 StatusId = car.StatusId,
								 StatusTitle = car.CarStatus.StatusTitle,
								 VehicleNo = car.VehicleNo
							 };

			ViewBag.CarRecords = carResults;

			return View ( );
		}

		[HttpPost]
		public ActionResult Create ( CarViewModel car )
		{
			var newCar = new Car ( )
			{
				VehicleNo = car.VehicleNo,
				RentalCarCode = car.RentalCarCode,
				TypeId = car.TypeId,
				ModelId = car.ModelId,
				MakeId = car.MakeId,
				AvailabilityId = car.AvailabilityId,
				YearsOfUse = car.YearsOfUse,
				MonthsOfUse = car.MonthsOfUse,
				SeatingCapacity = car.SeatingCapacity,
				DateCreated = DateTime.Now,
				DateModified = DateTime.Now,
				StatusId = car.StatusId
			};

			context.Cars.Add ( newCar );
			context.SaveChanges ( );

			return View ( newCar );
		}

		[HttpGet]
		public ActionResult UpdateRentalCarCode()
		{
			string rentalCarCode = Request.QueryString [ "rentalCode" ];
			int carId = Convert.ToInt32 ( Request.QueryString [ "carId" ] );

			var carToUpdate = context.Cars.Single ( c => c.CarId == carId );
			carToUpdate.RentalCarCode = rentalCarCode;
			carToUpdate.DateModified = DateTime.Now;

			context.Entry ( carToUpdate ).State = EntityState.Modified;
			context.Cars.Attach ( carToUpdate );
			context.SaveChanges ( );

			return View ( carToUpdate );
		}

		[HttpGet]
		public ActionResult UpdateVehicleNo()
		{
			string vehicleNo = Request.QueryString [ "vehicleNo" ];
			int carId = Convert.ToInt32 ( Request.QueryString [ "carId" ] );

			var carToUpdate = context.Cars.Single ( c => c.CarId == carId );
			carToUpdate.VehicleNo = vehicleNo;
			carToUpdate.DateModified = DateTime.Now;

			context.Entry ( carToUpdate ).State = EntityState.Modified;
			context.Cars.Attach ( carToUpdate );
			context.SaveChanges ( );

			return View ( carToUpdate );
		}

		[HttpGet]
		public ActionResult UpdateCarType()
		{
			int typeId = Convert.ToInt32 ( Request.QueryString [ "typeId" ] );
			int carId = Convert.ToInt32 ( Request.QueryString [ "carId" ] );

			var carToUpdate = context.Cars.Single ( c => c.CarId == carId );
			carToUpdate.TypeId = typeId;
			carToUpdate.DateModified = DateTime.Now;

			context.Entry ( carToUpdate ).State = EntityState.Modified;
			context.Cars.Attach ( carToUpdate );
			context.SaveChanges ( );

			return View ( carToUpdate );
		}

		[HttpGet]
		public ActionResult UpdateCarModel ( )
		{
			int modelId = Convert.ToInt32 ( Request.QueryString [ "modelId" ] );
			int carId = Convert.ToInt32 ( Request.QueryString [ "carId" ] );

			var carToUpdate = context.Cars.Single ( c => c.CarId == carId );
			carToUpdate.ModelId = modelId;
			carToUpdate.DateModified = DateTime.Now;

			context.Entry ( carToUpdate ).State = EntityState.Modified;
			context.Cars.Attach ( carToUpdate );
			context.SaveChanges ( );

			return View ( carToUpdate );
		}
    }
}