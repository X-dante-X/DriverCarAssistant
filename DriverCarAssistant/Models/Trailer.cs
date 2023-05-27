using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databases_for_driver_car.Models;

public class Trailer
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Nubmer { get; set; } = null!;
    public DateTime InsuranceDateOfIssue { get; set; }
    public DateTime InsuranceDateOfExpiry { get; set; }
    public DateTime ExtinguisherDateOfExpiry { get; set; }
}
