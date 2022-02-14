using System.ComponentModel.DataAnnotations;

namespace Vehicles.Api.Entities.Types
{
    public class Vehicles
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        [Required]
        [StringLength(2000)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the primary key and identifier.
        /// </summary>
        /// <value>The primary key and identifier.</value>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the image name.
        /// </summary>
        /// <value>The image name.</value>
        [Required]
        [StringLength(100)]
        public string ImageName { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        #endregion Public Properties
    }
}