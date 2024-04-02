// MIS 3013 001
// April 3, 2024
// Alexandra Camarena
// 113568154

// 
Console.WriteLine("class");
// cog: 80/each
// gear: 200/each
Order or1;
or1 = new Order();
or1.nCogs = 1;
or1.nGears = 2;

or1.subtotal = or1.CalSubtotal();

Console.WriteLine($"The subtotal is {or1.subtotal:C2}");

// end of your code
class Order
{ 
    public int nCogs;// by defualt, it is private
    public int nGears;
    public double subtotal;

    public double CalSubtotal() 
    {
        double r;
        r = 80 * nCogs + 200 * nGears;
        return r;
    }
}