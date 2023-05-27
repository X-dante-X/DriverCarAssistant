using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databases_for_driver_car.Models;

public class Driver
{
    public int DriverId { get; set; }
    public int? PESEL { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string SecondName { get; set; } = null!;
    public Passport Passport { get; set; } = null!;
    public DrivingLicense DrivingLicense { get; set; } = null!;
    public DateTime Code95DateOfIssue { get; set; }   
    public DateTime Code95DateOfExpiry { get; set; }   
    public Visa? Visa { get; set; }
    public DateTime TachoKardDateOfIssue { get; set; }
    public DateTime TachoKardDateOfExpiry { get; set; }
}
