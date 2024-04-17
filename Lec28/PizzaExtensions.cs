namespace CAExtensionMethods
{
    static class PizzaExtensions
    {
        public static Pizza AddDough(this Pizza value, string type)
        {
            value.Content += $"\n{type} Dough x $4.00";
            value.TotalPrice += 4m;
            return value;
        }
        public static Pizza AddDSauce(this Pizza value)
        {
            value.Content += $"\nTomato Sauce x $2.00";
            value.TotalPrice += 2m;
            return value;
        }
        public static Pizza AddDCheese(this Pizza value, bool extra)
        {
            value.Content += $"\n{(extra ? "Extra" : "Regular")} Cheese x {(extra ? "$4.00" : "$2.00")}";
            value.TotalPrice += (extra ? 4m : 2m);
            return value;
        }
        public static Pizza AddDToppings(this Pizza value, string type, decimal price)
        {
            value.Content += $"\n{type} X ${price.ToString("#.##")}";
            value.TotalPrice += price;
            return value;
        }


    }
}