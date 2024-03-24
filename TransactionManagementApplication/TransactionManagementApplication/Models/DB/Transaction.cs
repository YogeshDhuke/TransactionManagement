using System;
using System.Collections.Generic;

namespace TransactionManagementApplication.Models.DB;

public partial class Transaction
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public DateOnly? Date { get; set; }

    public decimal? Amount { get; set; }

    public int? CategoryId { get; set; }

    public int? TypeId { get; set; }

    public virtual Category? Category { get; set; }

    public virtual Type? Type { get; set; }

    public virtual User? User { get; set; }
}
