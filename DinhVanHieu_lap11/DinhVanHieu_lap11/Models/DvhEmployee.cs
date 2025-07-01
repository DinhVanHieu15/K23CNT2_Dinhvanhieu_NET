using System;
using System.Collections.Generic;

namespace DinhVanHieu_lap11.Models;

public partial class DvhEmployee
{
    public int DvhEmpId { get; set; }

    public string? DvhEmpName { get; set; }

    public string? DvhEmpLevel { get; set; }

    public DateOnly? DvhEmpStartDate { get; set; }

    public bool? DvhEmpStatus { get; set; }
}
