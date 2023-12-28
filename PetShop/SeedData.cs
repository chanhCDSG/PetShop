using PetShop.Models;
using Microsoft.EntityFrameworkCore;


namespace Doggo.Web.API
{





    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<ApplicationDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.pets.Any())
            {
                context.pets.AddRange(
                    new Pet
                    {
                        Name = "Doggo",
                        Age = 4,
                        Description = "A Doggo for one person",
                        Price = 275,
                        Image = "Doggo.png",
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    },
                    new Pet
                    {
                        Name = "Doggo2",
                        Age = 5,
                        Description = "A Doggo for one person",
                        Price = 275,
                        Image = "Doggo.png",
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    },
                    new Pet
                    {
                        Name = "Doggo3",
                        Age = 6,
                        Description = "A Doggo for one person",
                        Price = 275,
                        Image = "Doggo.png",
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    },
                    new Pet
                    {
                        Name = "Doggo4",
                        Age = 7,
                        Description = "A Doggo for one person",
                        Price = 275,
                        Image = "Doggo.png",
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    },
                    new Pet
                    {
                        Name = "Doggo5",
                        Age = 8,
                        Description = "A Doggo for one person",
                        Price = 275,
                        Image = "Doggo.png",
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    },
                    new Pet
                    {
                        Name = "Cat6",
                        Age = 5,
                        Description = "A Cat for one person",
                        Price = 275,
                        Image = "Cat.png",
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    },
                    new Pet
                    {
                        Name = "Cat7",
                        Age = 4,
                        Description = "A Cat for one person",
                        Price = 275,
                        Image = "Cat.png",
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    },
                    new Pet
                    {
                        Name = "Cat8",
                        Age = 3,
                        Description = "A Cat for one person",
                        Price = 275,
                        Image = "Cat.png",
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    },
                    new Pet
                    {
                        Name = "Cat9",
                        Age = 2,
                        Description = "A Cat for one person",
                        Price = 400,
                        Image = "Cat.png",
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    },
                    new Pet
                    {
                        
                        Name = "Cat10",
                        Age = 1,
                        Description = "A Cat for one person",
                        Price = 500,
                        Image = "Cat.png",
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    }
                );

                context.SaveChanges();
            }

            if (!context.Customers.Any())
            {
                context.Customers.AddRange(
                    new Customer
                    {
                        Name = "Nguyen Van A",
                        Email = "abc.@gmail.com",
                        Password = "password",
                        PhoneNumber = 123456,
                        Address = "TPHCM",
                        Created_Date = DateTime.Now,
                        Updated_Date = DateTime.Now,

                        
                    },
                    new Customer
                    {
                        Name = "Nguyen Van B",
                        Email = "abc.@gmail.com",
                        Password = "password",
                        PhoneNumber = 123456,
                        Address = "TPHCM",
                        Created_Date = DateTime.Now,
                        Updated_Date = DateTime.Now,
                    },
                    new Customer
                    {
                        Name = "Nguyen Thi C",
                        Email = "abc.@gmail.com",
                        Password = "password",
                        PhoneNumber = 123456,
                        Address = "TPHCM",
                        Created_Date = DateTime.Now,
                        Updated_Date = DateTime.Now,
                    },
                    new Customer
                    {
                        Name = "Nguyen Thi D",
                        Email = "abc.@gmail.com",
                        Password = "password",
                        PhoneNumber = 123456,
                        Address = "TPHCM",
                        Created_Date = DateTime.Now,
                        Updated_Date = DateTime.Now,
                    },
                    new Customer
                    {
                        Name = "Nguyen Thi E",
                        Email = "abc.@gmail.com",
                        Password = "password",
                        PhoneNumber = 123456,
                        Address = "TPHCM",
                        Created_Date = DateTime.Now,
                        Updated_Date = DateTime.Now,
                    },
                    new Customer
                    {
                        Name = "Huynh Cong C",
                        Email = "abc.@gmail.com",
                        Password = "password",
                        PhoneNumber = 123456,
                        Address = "TPHCM",
                        Created_Date = DateTime.Now,
                        Updated_Date = DateTime.Now,
                    },
                    new Customer
                    {
                        Name = "Vo Thi H",
                        Email = "abc.@gmail.com",
                        Password = "password",
                        PhoneNumber = 123456,
                        Address = "TPHCM",
                        Created_Date = DateTime.Now,
                        Updated_Date = DateTime.Now,
                    },
                    new Customer
                    {
                        Name = "Truong Van K",
                        Email = "abc.@gmail.com",
                        Password = "password",
                        PhoneNumber = 123456,
                        Address = "TPHCM",
                        Created_Date = DateTime.Now,
                        Updated_Date = DateTime.Now,
                    },
                    new Customer
                    {
                        Name = "Huynh Thi 7",
                        Email = "abc.@gmail.com",
                        Password = "password",
                        PhoneNumber = 123456,
                        Address = "TPHCM",
                        Created_Date = DateTime.Now,
                        Updated_Date = DateTime.Now,
                    },
                    new Customer
                    {
                        Name = "Tran Van I",
                        Email = "abc.@gmail.com",
                        Password = "password",
                        PhoneNumber = 123456,
                        Address = "TPHCM",
                        Created_Date = DateTime.Now,
                        Updated_Date = DateTime.Now,
                    }
                );

                context.SaveChanges();
            }
            
        }
    }
}
