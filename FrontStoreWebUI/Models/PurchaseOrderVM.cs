using StoreModels;

namespace FrontStoreWebUI.Models
{
    public class PurchaseOrderVM
    {
        public PurchaseOrderVM(PurchaseOrder p_pur)
        {
            this.OrderId = p_pur.OrderId;
            this.StoreId = p_pur.StoreId;
            this.CustomerId = p_pur.CustomerId;
            this.TotalPrice = p_pur.TotalPrice;

        }


        public int OrderId { get; set; }
        public int StoreId { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
