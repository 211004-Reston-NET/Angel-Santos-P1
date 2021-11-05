namespace StoreModels
{
    public class LineItem
    {   
        public int OrderId    { get; set; }

        public int Inventory    { get; set; }
    
        
        public override string ToString()
        {
            return $"OrderId: {OrderId}\nInventory:{Inventory}";
        }    
    }    
}

