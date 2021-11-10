using StoreModels;

namespace FrontStoreWebUI.Models
{
    public class LineItemVM
    {
        public LineItemVM()
        {

        }
        public LineItemVM(LineItem p_line)
        {
            this.LineId = p_line.LineId;
            this.OrderId = p_line.OrderId;
            this.ProdId = p_line.ProductId;
            this.Quantity = p_line.Quantity;

        }


        public int LineId { get; set; }
        public int OrderId { get; set; }
        public int ProdId { get; set; }
        public int Quantity { get; set; }

    }
}
