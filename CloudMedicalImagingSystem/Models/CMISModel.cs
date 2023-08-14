using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CloudMedicalImagingSystem.Models
{
    public partial class CMISModel : DbContext
    {
        public CMISModel()
            : base("name=CMISModel")
        {
        }

        public virtual DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<CloudMedicalImagingSystem.Models.Appointment> Appointments { get; set; }

        public System.Data.Entity.DbSet<CloudMedicalImagingSystem.Models.Location> Locations { get; set; }
    }
}
