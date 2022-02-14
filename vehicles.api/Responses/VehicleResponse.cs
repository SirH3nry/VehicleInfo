namespace Vehicles.Api.Responses
{
    public class VehicleResponse
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the primary key and identifier.
        /// </summary>
        /// <value>The primary key and identifier.</value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the image name.
        /// </summary>
        /// <value>The image name.</value>
        public string ImageName { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        #endregion Public Properties
    }
}
