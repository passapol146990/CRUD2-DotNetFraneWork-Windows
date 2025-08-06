using System;
using System.Collections.Generic;

namespace CRUD2_PASSAPOL;

public partial class TbCustomer
{
    public int CusId { get; set; }

    public string? CusName { get; set; }

    public string? CusLname { get; set; }

    public string? CusAdd { get; set; }

    public string? CusTel { get; set; }

    public DateTime? Bdate { get; set; }

    public string? Sex { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<TbBuy> TbBuys { get; set; } = new List<TbBuy>();
}
