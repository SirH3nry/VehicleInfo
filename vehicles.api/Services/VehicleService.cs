using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicles.Api.Common;
using Vehicles.Api.Entities.Context;
using Vehicles.Api.Fixtures;
using Vehicles.Api.Responses;

namespace Vehicles.Api.Services
{
    public class VehicleService : IVehicleService
    {
        #region Public Methods

        /// <inheritdoc />
        public Task<IEnumerable<VehicleResponse>> GetAllVehicles()
        {
            List<VehicleResponse> responses = new();

            // If you have the database set up, then change the following boolean to true
            bool hasDatabase = true;

            if (hasDatabase)
            {
                using (MasterContext dbContext = new())
                {
                    DbSet<Entities.Types.Vehicles> vehicles = dbContext.Vehicles;

                    foreach (Entities.Types.Vehicles vehicle in vehicles)
                    {
                        responses.Add(new()
                        {
                            Description = vehicle.Description,
                            Id = vehicle.Id,
                            ImageName = vehicle.ImageName,
                            Name = vehicle.Name
                        });
                    }
                }
            }
            else
            {
                responses.Add(VehicleFixtures.FordTaurus);
                responses.Add(VehicleFixtures.HondaCivic);
                responses.Add(VehicleFixtures.JeepRubicon);
                responses.Add(VehicleFixtures.TeslaModel3);
            }

            return Task.FromResult(responses.AsEnumerable());
        }

        /// <inheritdoc />
        public Task<VehicleResponse> GetVehicle(int id)
        {
            VehicleResponse response = new();

            using (MasterContext dbContext = new())
            {
                var vehicle = dbContext.Vehicles.FirstOrDefault(v => v.Id.Equals(id));

                response = new()
                {
                    Description = vehicle.Description,
                    Id = vehicle.Id,
                    ImageName = vehicle.ImageName,
                    Name = vehicle.Name
                };
            }

            return Task.FromResult(response);
        }

        #endregion Public Methods
    }
}
