using System;
using System.Collections.Generic;

namespace MilkTeaManagerDAL.Models;

public partial class TbTable
{
    public long Id { get; set; }

    public string? NameTb { get; set; }

    public string? Description { get; set; }

    public long? IdGroup { get; set; }

    public bool? Status { get; set; }
}
