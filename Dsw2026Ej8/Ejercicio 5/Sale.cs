namespace Dsw2026Ej8;

public class Sale
{
    public decimal Subtotal;

    public virtual decimal CalculateTotal()
    {
        return Subtotal;
    }
}

public class RetailSale : Sale
{
    public override decimal CalculateTotal()
    {
        return Subtotal;
    }
}

public class WholesaleSale : Sale
{
    public override decimal CalculateTotal()
    {
        return Subtotal * 0.90m;
    }
}

