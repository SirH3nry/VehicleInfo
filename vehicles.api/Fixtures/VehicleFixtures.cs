using Vehicles.Api.Responses;

namespace Vehicles.Api.Fixtures
{
    /// <summary>
    /// Mocked vehicle fixtures for use in testing or if you don't have a database setup.
    /// </summary>
    public static class VehicleFixtures
    {
        #region Public Properties

        /// <summary>
        /// The mighty ford taurus.
        /// </summary>
        public static VehicleResponse FordTaurus { get; set; } = new()
        {
            Description = "The best car ever made, second only to the wagon edition.",
            Id = 1,
            ImageName = "ford-taurus",
            Name = "Ford Taurus"
        };

        /// <summary>
        /// The longevous honda civic.
        /// </summary>
        public static VehicleResponse HondaCivic { get; set; } = new()
        {
            Description = "Survives for longer than 100,000 miles.",
            Id = 2,
            ImageName = "honda-civic",
            Name = "Honda Civic"
        };

        /// <summary>
        /// The exciting jeep rubicon.
        /// </summary>
        public static VehicleResponse JeepRubicon { get; set; } = new()
        {
            Description = "Cool looking car, expensive parts.",
            Id = 3,
            ImageName = "jeep-rubicon",
            Name = "Jeep Rubicon"
        };

        /// <summary>
        /// The fancy tesla model 3.
        /// </summary>
        public static VehicleResponse TeslaModel3 { get; set; } = new()
        {
            Description = "Electric vehicle, still not quite affordable.",
            Id = 4,
            ImageName = "tesla-model3",
            Name = "Tesla Model 3"
        };

        #endregion Public Properties
    }
}
