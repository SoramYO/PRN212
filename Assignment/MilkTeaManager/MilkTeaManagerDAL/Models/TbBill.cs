using System;
using System.Collections.Generic;

namespace MilkTeaManagerDAL.Models;

public partial class TbBill
{
    public long Id { get; set; }

    public long? IdTable { get; set; }

    public DateTime? BillDate { get; set; }

    public double? TotalMoney { get; set; }

    public bool? Status { get; set; }

    public string? Description { get; set; }

    public long? IdUser { get; set; }

    public long? IdCustomer { get; set; }
}
