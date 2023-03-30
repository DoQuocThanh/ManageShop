using System;
using System.Collections.Generic;

namespace ManageShopWeb;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public int AmountBuy { get; set; }


}
