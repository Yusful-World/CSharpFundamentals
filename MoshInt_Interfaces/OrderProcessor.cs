using System;

namespace MoshInt_Interfaces
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;
        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }
        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order has already been processed");

            order.Shipment = new Shipment()
            {
                Cost = _shippingCalculator.CalculateShippingOrder(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}
