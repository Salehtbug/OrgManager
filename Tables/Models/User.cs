using System;
using System.Collections.Generic;

namespace Tables.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }
}
