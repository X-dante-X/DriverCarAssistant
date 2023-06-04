using DriverCarAssistant.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace DriverCarAssistant.DBContext;

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
        string currentDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)).FullName).FullName).FullName;
        string dbFilePath = Path.Combine(currentDirectory, "database.db3");
        SqliteConnectionStringBuilder builder = new SqliteConnectionStringBuilder();
        builder.DataSource = dbFilePath;
        string connectionString = builder.ConnectionString;
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite(connectionString);
        optionsBuilder.EnableSensitiveDataLogging();
    }
}
