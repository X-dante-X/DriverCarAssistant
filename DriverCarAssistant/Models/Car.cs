using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databases_for_driver_car.Models;

public class Car
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Nubmer { get; set; } = null!;
    public DateTime LicenseDateOfIssue { get; set; }
    public DateTime LicenseDateOfExpiry { get; set; }
    public DateTime MaintenanceDateOfIssue { get; set; }
    public DateTime MaintenanceDateOfExpiry { get; set; }
    public DateTime InsuranceDateOfIssue { get; set; }
    public DateTime InsuranceDateOfExpiry { get; set; }
    public DateTime LPacketDateOfIssue { get; set; }
    public DateTime LPacketDateOfExpiry { get; set; }
    public DateTime TachoСalibrationDateOfIssue { get; set; }
    public DateTime TachoСalibrationDateOfExpiry { get; set; }
    public DateTime ExtinguisherDateOfExpiry { get; set; }
    public int Service { get; set; }
}
