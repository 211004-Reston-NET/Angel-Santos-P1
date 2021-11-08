namespace StoreModels
{
    public class LineItem
    {   
        public int LineId    { get; set; }
        public int OrderId {get; set;}
        public int ProdId { get; set; }
        public int Quantity    { get; set; }
    
        
        /*public override string ToString()
        {
            return $"OrderId: {LineId}\nInventory:{Inventory}";
        } 
        */   
    }    
}

