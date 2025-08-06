using System;
using System.Collections.Generic;

namespace CRUD2_PASSAPOL;

public partial class TbProduct
{
    public int ProId { get; set; }

    public string ProName { get; set; } = null!;

    public int ProNum { get; set; }

    public int ProTypeid { get; set; }

    public string ProDesc { get; set; } = null!;

    public byte[]? ProImage { get; set; }

    public virtual ProductType ProType { get; set; } = null!;

    public virtual ICollection<TbBuy> TbBuys { get; set; } = new List<TbBuy>();
}
