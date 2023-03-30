using System;
using System.Collections.Generic;

namespace ManageShopWeb;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string Chip { get; set; } = null!;

    public string OperatingSystem { get; set; } = null!;

    public string PhoneScreen { get; set; } = null!;

    public double Price { get; set; }


}
