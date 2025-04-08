using System;
using System.Collections.Generic;

namespace examples.Server.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string? Category { get; set; }

    public decimal? Price { get; set; }

    public int? Quantity { get; set; }

    public DateTime? CreatedAt { get; set; }
}
