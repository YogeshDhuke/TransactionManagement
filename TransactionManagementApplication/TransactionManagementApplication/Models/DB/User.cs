using System;
using System.Collections.Generic;

namespace TransactionManagementApplication.Models.DB;

public partial class User
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string UserFullName { get; set; } = null!;

    public string? Email { get; set; }

    public decimal? PhoneNo { get; set; }

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
