using databases_for_driver_car.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databases_for_driver_car.DBContext;

public class Context : DbContext
{
    public DbSet<Driver> Drivers { get; set; } = null!;
    public DbSet<DrivingLicense> DrivingLicense { get; set; } = null!;
    public DbSet<Passport> Passport { get; set; } = null!;
    public DbSet<Visa> Visa { get; set; } = null!;
    public DbSet<Car> Cars { get; set; } = null!;
    public DbSet<Trailer> Trailers { get; set; } = null!;


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //Add-Migration InitalCreate
        //Update-Database
        string connectionString = "Data Source=D:\\Projects\\databases for driver car\\databases for driver car\\database.db3";
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite(connectionString);
        optionsBuilder.EnableSensitiveDataLogging();
    }
}
