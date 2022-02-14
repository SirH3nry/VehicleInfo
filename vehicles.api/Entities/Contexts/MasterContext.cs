using Microsoft.EntityFrameworkCore;

namespace Vehicles.Api.Entities.Context
{
    public partial class MasterContext : DbContext
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MasterContext"/> class.
        /// </summary>
        public MasterContext()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MasterContext"/> class.
        /// </summary>
        /// <param name="options">The db context options.</param>
        public MasterContext(DbContextOptions<MasterContext> options)
            : base(options)
        { }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// The vehicles db set.
        /// </summary>
        public virtual DbSet<Types.Vehicles> Vehicles { get; set; }

        #endregion Public Properties

        #region Protected Methods

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Types.Vehicles>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.ImageName).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            base.OnModelCreating(modelBuilder);
        }

        #endregion Protected Methods
    }
}