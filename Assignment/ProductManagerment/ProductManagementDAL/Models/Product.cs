using System;
using System.Collections.Generic;

namespace ProductManagementDAL.Models;

public partial class Product
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int? CategoryId { get; set; }

    public string? ImagePath { get; set; }

    public string? QrCode { get; set; }

    public string? BarCode { get; set; }

    public virtual Category? Category { get; set; }
}
