namespace StoreModels
{
    public class Inventory
    {   
        public int InvId    { get; set; }
        public int StoreId {get; set;}
        public int ProdId { get; set; }
        public int Quantity    { get; set; }

        public virtual Product Products { get; set;}
        public virtual LineItem LineItems {get; set;}
        public virtual StoreFront StoreInv {get; set;}
        
    }    
}

