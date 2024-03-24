using System;
using System.Collections.Generic;

namespace TransactionManagementApplication.Models;

public partial class Type
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
