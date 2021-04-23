using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using HarborControl.Domains;

namespace HarborControl.Data
{
   public class HarborControlContext :DbContext
    {
        public HarborControlContext(DbContextOptions<HarborControlContext> option)
            :base(option)
        {

        }

        public virtual DbSet<BoatStatuses> BoatStatuses { get; set; }
        public virtual DbSet<BoatTypes> BoatTypes { get; set; }
        public virtual DbSet<DockedBoats> DockedBoats { get; set; }
        public virtual DbSet<HarborQues> HarborQues { get; set; }
        public virtual DbSet<Harbors> Harbors { get; set; }
        public virtual DbSet<MesuringUnits> MesuringUnits { get; set; }



        protected   override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            DateTime createdDate = new DateTime(2021,04,19,20,00,00,0);
            DateTime modifiedDate = new DateTime(2021, 04, 19, 20, 00, 00, 0);


            #region Mesuring units
            var mesuringUnit1 = new MesuringUnits() 
            {
                Id = new Guid("BC098656-F905-4642-9FF8-0232A7EE3A32"),
                Active= true,
                CreatedDate= createdDate,
                ModifiedDate=modifiedDate,
                Name="km/h",
                Code=Constants.MesuringUnitsCodeKiloPerHour

            };
            var mesuringUnit2 = new MesuringUnits()
            {
                Id = new Guid("698366A2-F82D-4759-97F6-101E9E8A1526"),
                Active = true,
                CreatedDate = createdDate,
                ModifiedDate = modifiedDate,
                Name = "km",
                Code = Constants.MesuringUnitsCodeKiloMeter

            };
            var mesuringUnit3 = new MesuringUnits()
            {
                Id = new Guid("A2AD6A55-6147-4517-B370-41A04CFC555C"),
                Active = false,
                CreatedDate = createdDate,
                ModifiedDate = modifiedDate,
                Name = "miles",
                Code= Constants.MesuringUnitsCodeMile

            };

            modelBuilder.Entity<MesuringUnits>().HasData(mesuringUnit1, mesuringUnit2, mesuringUnit3);

            #endregion


            #region Harbors
            var harbor1 = new Harbors()
            {
                Id = new Guid("36A8FC3A-501E-4943-A950-40902850BC47"),
                Active = true,
                CreatedDate = createdDate,
                ModifiedDate = modifiedDate,
                Name = "Durban",
                Code = Constants.HarborCodeDurban,
                Parameter = 10,
                MesuringUnitsId = mesuringUnit2.Id


            };
            var harbor2 = new Harbors()
            {
                Id = new Guid("7128AC76-34E7-46AA-83D9-32DBC0A97FCD"),
                Active = false,
                CreatedDate = createdDate,
                ModifiedDate = modifiedDate,
                Name = "Cape Town",
                Code= Constants.HarborCodeCapeTown,
                Parameter = 10,
                MesuringUnitsId = mesuringUnit2.Id
            };
            modelBuilder.Entity<Harbors>().HasData(harbor1, harbor2);
            #endregion


            #region Status

            var statue1 = new BoatStatuses()
            {
                Id = new Guid("74FD6DD2-2166-489A-A076-94B12A9D6D38"),
                Active = true,
                CreatedDate = createdDate,
                ModifiedDate = modifiedDate,
                Name = "Docked",
                Code= Constants.BoatStatusCodeDocked
                
            };
            var statue2 = new BoatStatuses()
            {
                Id = new Guid("E87EF917-6010-4B4E-8BA8-0A9E99CCC8BC"),
                Active = true,
                CreatedDate = createdDate,
                ModifiedDate = modifiedDate,
                Name = "Arriving",
                Code= Constants.BoatStatusCodeArriving

            };
            var statue3 = new BoatStatuses()
            {
                Id = new Guid("BE094685-5E2B-49A2-A43C-D99462BFDA2A"),
                Active = true,
                CreatedDate = createdDate,
                ModifiedDate = modifiedDate,
                Name = "Docking",
                Code = Constants.BoatStatusCodeDocking

            };
            var statue4 = new BoatStatuses()
            {
                Id = new Guid("46B17989-5742-4FC4-8CB1-0CB982EEFD8C"),
                Active = true,
                CreatedDate = createdDate,
                ModifiedDate = modifiedDate,
                Name = "OnQueue",
                Code = Constants.BoatStatusCodeOnQueue
            };
            modelBuilder.Entity<BoatStatuses>().HasData(statue1, statue2, statue3, statue4);

            #endregion


            #region BoatType

            var boat1 = new BoatTypes()
            {
                Id = new Guid("DD23FD5D-6C80-47CC-8F8B-1E471F23185D"),
                Active= true,
                BoatType="Speedboat",
                CreatedDate = createdDate,
                ModifiedDate = modifiedDate,
                Speed = 30,
                MesuringUnitsId = mesuringUnit1.Id
            };


            var boat2 = new BoatTypes()
            {
                Id = new Guid("78063F1B-5E7D-4BCE-9F23-E4F249163338"),
                Active = true,
                BoatType = "Sailboat",
                CreatedDate = createdDate,
                ModifiedDate = modifiedDate,
                Speed = 15,
                MesuringUnitsId = mesuringUnit1.Id
            };

            var boat3 = new BoatTypes()
            {
                Id = new Guid("54533DA8-1701-41BF-A3E8-9207C71A0B50"),
                Active = true,
                BoatType = "Cargo Ship",
                CreatedDate = createdDate,
                ModifiedDate = modifiedDate,
                Speed = 5,
                MesuringUnitsId = mesuringUnit1.Id
            };
            modelBuilder.Entity<BoatTypes>().HasData(boat1, boat2, boat3);

            #endregion




        }



    }
}
