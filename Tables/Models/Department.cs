using System;
using System.Collections.Generic;

namespace Tables.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public string? Manager { get; set; }

    public string? Location { get; set; }

    public DateTime? CreatedDate { get; set; }
}
