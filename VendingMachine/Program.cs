using System;
using System.Linq;

class VendingMachine
{
    private int totalCoins = 0;
    private int productPrice = 20; // price in cents
    public void InsertCoin(int coin)
    {
        if (coin == 10 || coin == 20 || coin == 50 || coin == 100)
        {
            totalCoins += coin;
            Console.WriteLine("Coin inserted: {0} cents", coin);
        }
        else
        {
            Console.WriteLine("Invalid coin. Only 10, 20, 50 and 100 cents coins are accepted.");
        }
    }

    public void BuyProduct()
    {
        if (totalCoins >= productPrice)
        {
            int change = totalCoins - productPrice;
            Console.WriteLine("Product dispensed. Change: {0} cents", change);
            totalCoins = 0;
        }
        else
        {
            Console.WriteLine("Not enough money. Insert more coins.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        VendingMachine vm = new VendingMachine();
        vm.InsertCoin(50);
        vm.InsertCoin(20);
        vm.InsertCoin(20);
        vm.InsertCoin(20);
        vm.InsertCoin(10);
        vm.BuyProduct();
    }
}
