using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databases_for_driver_car.Models;

public class DrivingLicense
{
    [ForeignKey("Driver")]
    public int Id { get; set; }
    public DateTime DateOfIssue { get; set; }
    public DateTime DateOfExpiry { get; set; }
    public Driver Driver { get; set; } = null!;

}
