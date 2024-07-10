using System;
using System.Collections.Generic;

namespace MilkTeaManagerDAL.Models;

public partial class Employee
{
    public long Id { get; set; }

    public string? FullName { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Address { get; set; }

    public string? IdCard { get; set; }

    public DateOnly? DateWork { get; set; }

    public byte[]? Img { get; set; }

    public bool? Status { get; set; }
}
