using System;
using System.Collections.Generic;

namespace WebApplication11.Models;

public partial class Cart
{
    public int UserId { get; set; } // Ссылка на пользователя
    public int ProductId { get; set; } // Ссылка на продукт
    public int Quantity { get; set; } // Количество продукта

    public virtual User User { get; set; }
    public virtual Catalog Product { get; set; }
}
