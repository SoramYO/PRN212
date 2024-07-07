using System;
using System.Collections.Generic;

namespace MilkTeaManagerDAL.Models;

public partial class LoginRole
{
    public long Id { get; set; }

    public long? IdLogin { get; set; }

    public int? IdMenuItems { get; set; }
}
