﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCarAssistant.Models;

public class Visa
{
    [ForeignKey("Driver")]
    [Key]
    public int Id { get; set; }
    public string VisaNumber { get; set; } = null!;
    public DateTime DateOfIssue { get; set; }
    public DateTime DateOfExpiry { get; set; }
    public Driver Driver { get; set; } = null!;

}
