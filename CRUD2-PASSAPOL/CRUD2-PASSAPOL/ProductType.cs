using System;
using System.Collections.Generic;

namespace CRUD2_PASSAPOL;

public partial class ProductType
{
    public int TypeId { get; set; }

    public string? TypeName { get; set; }

    public virtual ICollection<TbProduct> TbProducts { get; set; } = new List<TbProduct>();
}
