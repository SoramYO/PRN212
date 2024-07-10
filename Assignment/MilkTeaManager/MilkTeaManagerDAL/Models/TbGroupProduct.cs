using System;
using System.Collections.Generic;

namespace MilkTeaManagerDAL.Models;

public partial class TbGroupProduct
{
    public long IdGr { get; set; }

    public string? NameGr { get; set; }

    public string? DescriptionGr { get; set; }
}
