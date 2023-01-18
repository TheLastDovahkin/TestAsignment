using System;
using TestAsignment.Models;
using TestAsignment.Repositories.Interfaces;
using TestAsignment.Services.Interface;

namespace TestAsignment
{
    public class RepairService : IRepairService
    {
        private IBaseRepository<Document> Documents { get; set; }
        private IBaseRepository<Car> Cars { get; set; }
        private IBaseRepository<Worker> Workers { get; set; }

        public void Work()
        {
            var rand = new Random();
            var carId = Guid.NewGuid();
            var workerId = Guid.NewGuid();

            Cars.Create(new Car
            {
                Id = carId, 
                Name = String.Format($"Car{rand.Next()}"),
                Number = String.Format($"Number{rand.Next()}")
            });

            Workers.Create(new Worker
            {

                Id = workerId,
                Name = String.Format($"Car{rand.Next()}"),
                Position = String.Format($"{rand.Next()}"),
                PhoneNumber = String.Format($"38097{rand.Next()},{rand.Next()}{rand.Next()}{rand.Next()}{rand.Next()}{rand.Next()}{rand.Next()}")
            });

            var car = Cars.Get(carId);
            var worker = Workers.Get(workerId);

            Documents.Create(new Document
            {
               CarId = car.Id,
               WorkerId = worker.Id,
               Car = car,
               Worker = worker
            });
        }
    }
}
