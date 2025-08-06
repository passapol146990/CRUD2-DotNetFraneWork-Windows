using System;
using System.Collections.Generic;

namespace CRUD2_PASSAPOL;

public partial class TbBuy
{
    public int Id { get; set; }

    public int ProId { get; set; }

    public int CusId { get; set; }

    public DateOnly Date { get; set; }

    public virtual TbCustomer Cus { get; set; } = null!;

    public virtual TbProduct Pro { get; set; } = null!;
}
