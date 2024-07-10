﻿using System;
using System.Collections.Generic;

namespace MilkTeaManagerDAL.Models;

public partial class TbProduct
{
    public long Id { get; set; }

    public long? IdGroupProduct { get; set; }

    public string? Name { get; set; }

    public string? Unit { get; set; }

    public double? UnitPrice { get; set; }

    public string? Description { get; set; }

    public byte[]? Img { get; set; }
}
