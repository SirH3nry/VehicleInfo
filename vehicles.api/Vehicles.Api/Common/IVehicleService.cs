using System.Collections.Generic;
using System.Threading.Tasks;
using Vehicles.Api.Responses;

namespace Vehicles.Api.Common
{
    public interface IVehicleService
    {
        #region Public Methods

        /// <summary>
        /// Gets all vehicles.
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<VehicleResponse>> GetAllVehicles();

        /// <summary>
        /// Gets a single vehicle by identifier.
        /// </summary>
        /// <param name="id">The identifier</param>
        /// <returns></returns>
        public Task<VehicleResponse> GetVehicle(int id);

        #endregion Public Methods
    }
}
