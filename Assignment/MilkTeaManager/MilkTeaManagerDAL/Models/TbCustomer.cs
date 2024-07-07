using System;
using System.Collections.Generic;

namespace MilkTeaManagerDAL.Models;

public partial class TbCustomer
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Description { get; set; }

    public bool? Status { get; set; }
}
