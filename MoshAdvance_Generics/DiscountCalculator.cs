namespace MoshAdvance_Generics
{
    //T : Product - applying Generics to class and/or subclasses
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }
}
