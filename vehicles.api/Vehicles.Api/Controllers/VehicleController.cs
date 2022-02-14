using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vehicles.Api.Common;
using Vehicles.Api.Responses;

namespace Vehicles.Api.Controllers
{
    [ApiController]
    [Route("api/vehicles")]
    public class VehicleController : ControllerBase
    {
        #region Private Fields

        private readonly IVehicleService _service;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleController"/> class.
        /// </summary>
        public VehicleController(IVehicleService service)
        {
            _service = service;
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// Gets and returns all of the vehicles.
        /// </summary>
        [HttpGet("")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<VehicleResponse>))]
        public async Task<ActionResult<IEnumerable<VehicleResponse>>> GetAllVehicles()
        {
            var result = await _service.GetAllVehicles();

            if (result is null)
                return StatusCode(500, result);

            return Ok(result);
        }

        /// <summary>
        /// Gets and returns all of the vehicles.
        /// </summary>
        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<VehicleResponse>))]
        public async Task<ActionResult<IEnumerable<VehicleResponse>>> GetVehicle([FromRoute] int id)
        {
            if (id <= 0)
                return BadRequest(new { message = $"The provided vehicle identifier is invalid: [{id}]" });

            var result = await _service.GetVehicle(id);
            if (result is null)
                return StatusCode(500, result);

            return Ok(result);
        }

        #endregion Public Methods
    }
}
