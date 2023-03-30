using System;
using System.Collections.Generic;

namespace ManageShopWeb;

public partial class Bill
{
    public int BillId { get; set; }

    public int CustomerId { get; set; }

    public int EmployeeId { get; set; }

    public DateTime? Time { get; set; }


}
