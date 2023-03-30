using System;
using System.Collections.Generic;

namespace ManageShop;

public partial class Bill
{
    public int BillId { get; set; }

    public int CustomerId { get; set; }

    public int EmployeeId { get; set; }

    public DateTime? Time { get; set; }


}
