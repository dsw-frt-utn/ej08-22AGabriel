namespace Dsw2026Ej8;

public class Problema3
{
    public string CompararCopias(int originalValue, Product product)
    {
        int copyValue = originalValue + 1;

        Product copyProduct = product;

        copyProduct.ModificarDescripcion("Descripción modificada");

        return $"{originalValue}-{copyValue}-{copyProduct.Description}";
    }
}