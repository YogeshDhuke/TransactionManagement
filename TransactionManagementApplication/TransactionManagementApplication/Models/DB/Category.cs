using System;
using System.Collections.Generic;

namespace TransactionManagementApplication.Models.DB;

public partial class Category
{
    public int Id { get; set; }

    public string Category1 { get; set; } = null!;

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
