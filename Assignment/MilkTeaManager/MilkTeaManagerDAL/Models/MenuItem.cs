using System;
using System.Collections.Generic;

namespace MilkTeaManagerDAL.Models;

public partial class MenuItem
{
    public int Id { get; set; }

    public string? NameMenu { get; set; }

    public string? NameShow { get; set; }
}
