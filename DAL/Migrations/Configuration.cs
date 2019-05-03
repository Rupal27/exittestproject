namespace DAL.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DAL.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }



        protected override void Seed(DAL.DatabaseContext context)
        {
            //    var members = new List<Member>
            //    {   new Member{ Email = "rupkap@gmail.com",
            //            MemberID=1,
            //            FirstName = "Rupal",
            //            LastName = "Kapoor",
            //            Password = "123",
            //            ProfileImage = "abc",
            //            AadharNo = "12",
            //            CreatedOn = DateTime.Now,
            //            ModifiedOn = DateTime.Now

            //        },
            //        new Member{
            //            MemberID=2,
            //            Email = "riya@gmail.com",
            //            FirstName = "Riya",
            //            LastName = "Kapoor",
            //            Password = "1234",
            //            ProfileImage = "abcd",
            //            AadharNo = "123",
            //            CreatedOn = DateTime.Now,
            //            ModifiedOn = DateTime.Now,

            //        }
            //    };
            //    members.ForEach(m => context.Members.AddOrUpdate(m));
            //    context.SaveChanges();

            //    var house = new List<HouseListing>
            //    { new HouseListing()
            //        {   HouseListingID=1,
            //            ApartmentNumber = "123",
            //            StreetName = "Dover Street",
            //            City = "Gurgaon",
            //            State = "Haryana",
            //            NameOfHead = "Rupal",
            //            OwnershipStatus = Shared_Layer.Enum.OwnershipStatus.Owner,
            //            CreatedOn = DateTime.Now,
            //            ModifiedOn = DateTime.Now
            //        },
            //        new HouseListing()
            //        {
            //            HouseListingID =2,
            //            ApartmentNumber = "345",
            //            StreetName = "Hollywood Boulevard",
            //            City = "San Jose",
            //            State = "California",
            //            NameOfHead = "Aditi",
            //            OwnershipStatus = Shared_Layer.Enum.OwnershipStatus.Rented,
            //            CreatedOn = DateTime.Now,
            //            ModifiedOn = DateTime.Now
            //        },
            //        new HouseListing()
            //        {
            //            HouseListingID=3,
            //            ApartmentNumber = "567",
            //            StreetName = "Dallas Boulevard",
            //            City = "San Jose",
            //            State = "California",
            //            NameOfHead = "Priya",
            //            OwnershipStatus = Shared_Layer.Enum.OwnershipStatus.Owner,
            //            CreatedOn = DateTime.Now,
            //            ModifiedOn = DateTime.Now
            //        }
            //    };
            //    house.ForEach(h => context.HouseListings.AddOrUpdate(h));
            //    context.SaveChanges();
            //    var people = new List<PopulationRegistration>
            //    { new PopulationRegistration()
            //        {   PopulationRegistrationID=1,
            //            RelationToHead = Shared_Layer.Enum.RelationToHead.Self,
            //            Gender = Shared_Layer.Enum.Gender.Female,
            //            DOB= DateTime.Now,
            //            FullName="Rupal Kapoor",
            //            AgeAtMarriage=19,
            //            MaritalStatus = Shared_Layer.Enum.MaritalStatus.Unmarried,
            //            OccupationStatus = Shared_Layer.Enum.OccupationStatus.Employed,
            //            NatureOfOccupation = Shared_Layer.Enum.NatureOfOccupation.Private,
            //            CreatedOn = DateTime.Now,
            //            ModifiedOn = DateTime.Now,
            //            MemberID=1,
            //            HouseListingID=1


            //        },
            //        new PopulationRegistration()
            //        { PopulationRegistrationID=2,
            //            RelationToHead = Shared_Layer.Enum.RelationToHead.Son,
            //            Gender = Shared_Layer.Enum.Gender.Male,
            //            MaritalStatus = Shared_Layer.Enum.MaritalStatus.Married,
            //            OccupationStatus = Shared_Layer.Enum.OccupationStatus.Student,
            //            NatureOfOccupation = Shared_Layer.Enum.NatureOfOccupation.Public,
            //            CreatedOn = DateTime.Now,
            //            DOB= DateTime.Now,
            //            FullName="Riya Kapoor",
            //            AgeAtMarriage=10,
            //            ModifiedOn = DateTime.Now,
            //            MemberID=2,
            //            HouseListingID=2

            //        }
            //    };
            //    people.ForEach(p => context.PopulationRegistrations.AddOrUpdate(p));
            //    context.SaveChanges();
            //    var users = new List<UserRequestStatus>
            //    {
            //        new UserRequestStatus()
            //        {
            //            RequestStatus = Shared_Layer.Enum.RequestStatus.Accepted,
            //            MemberID=1,
            //            UserRequestStatusID=1,
            //            CreatedOn = DateTime.Now,
            //            ModifiedOn = DateTime.Now
            //        }
            //    };
            //   users.ForEach(u => context.UserRequestStatuss.AddOrUpdate(u));
            //    context.SaveChanges();
            //    //  This method will be called after migrating to the latest version.
            //    //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //    //  to avoid creating duplicate seed data.

            //
        }
    }
}
