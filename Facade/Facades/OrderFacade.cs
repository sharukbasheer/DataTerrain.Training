using Facade.Subsystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Facades
{
    public class OrderFacade
    {
        private readonly InventoryService _inventoryService;
        private readonly PaymentService _paymentService;
        private readonly ShippingService _shippingService;
        private readonly NotificationService _notificationService;

        public OrderFacade()
        {
            _inventoryService = new InventoryService();
            _paymentService = new PaymentService();
            _shippingService = new ShippingService();
            _notificationService = new NotificationService();
        }

        public void PlaceOrder(string productId, decimal amount)
        {
            if (!_inventoryService.IsInStock(productId))
                return;

            if (!_paymentService.ProcessPayment(amount))
                return;

            _shippingService.ShipProduct(productId);
            _notificationService.SendConfirmation();
        }
    }
}
