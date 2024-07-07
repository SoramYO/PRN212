using System;
using System.Collections.Generic;

namespace MilkTeaManagerDAL.Models;

public partial class Login
{
    public long Id { get; set; }

    public long? IdEmployees { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public bool? IsUse { get; set; }
}
