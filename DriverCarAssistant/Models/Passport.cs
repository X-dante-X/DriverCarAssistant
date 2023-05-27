using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databases_for_driver_car.Models;

public class Passport
{
    [ForeignKey("Driver")]
    [Key]
    public int Id { get; set; }
    public string PassportNumber { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
    public DateTime DateOfIssue { get; set; }
    public DateTime DateOfExpiry { get; set; }
    public Driver Driver { get; set; } = null!;

}
