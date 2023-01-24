// See https://aka.ms/new-console-template for more information
using Stock_Purchase;

Console.WriteLine("Hello, World!");


Dictionary<string, string> stocks = new Dictionary<string, string>();
stocks.Add("GM", "General Motors");
stocks.Add("CAT", "Caterpillar");
stocks.Add("TSLA", "Tesla");
stocks.Add("GE", "General Electric");

// Add a few more of your favorite stocks


Dictionary<string, double> currentStockValues = new Dictionary<string, double>();
currentStockValues.Add("GM", 23.21);
currentStockValues.Add("CAT", 33.34);
currentStockValues.Add("GE", 18.23);
currentStockValues.Add("TSLA", 50.34);

// Add a few more of your favorite stocks




string GM = stocks["GM"];

List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

purchases.Add((ticker: "TSLA", shares: 150, price: 101.21));
purchases.Add((ticker: "GE", shares: 32, price: 17.87));
purchases.Add((ticker: "GE", shares: 80, price: 19.02));
// Add more for each stock you added to the stocks dictionary

purchases.Add((ticker: "CAT", shares: 35, price: 18.33));
purchases.Add((ticker: "CAT", shares: 100, price: 40.33));

purchases.Add((ticker: "GM", shares: 80, price: 19.02));





//Create a total ownership report that computes the total value of each stock that you have purchased.


//step 1. a new dictionary created from the one that already was named.
//loop trhouugh the purchases list.
//we will need to find the Full name of the stock
//we will need to total the shares and price.
//We should hhave a current price of the share.
//we should have the total current value of the share.
//How can we calculate overall gain/loss of a stock price? We need to compare the current value of the share with the original purchase price. We then add that number to gain/loss. 



Dictionary<string, StockValuation> portfolio = new Dictionary<string, StockValuation>();
//aggregate results based on ticker name to get total shares.
//aggregate resullts based on ticker name to get gain/loss.

//How can we know how many of something to add?
foreach ((string ticker, int shares, double price) item in purchases)
{
    string stockName = stocks[item.ticker];
    double stockCurrentValue = currentStockValues[item.ticker];

    //check to see if portfolio dictionary contains the current full name of the stock as the key,
    if (!portfolio.ContainsKey(stockName))
    {
        portfolio.Add(stockName, new StockValuation());
    }
    StockValuation currentStock = portfolio[stockName];
    currentStock.TotalShares += item.shares;
    currentStock.GainLoss += stockCurrentValue * item.shares - item.shares * item.price;
    currentStock.TotalCurrentStockValue += stockCurrentValue * item.shares;
}

foreach (KeyValuePair<string, StockValuation> item in portfolio)
{
    Console.WriteLine(item);
}

Console.ReadLine();



//This is the basic relational database join algorithm between two tables.





/*
 * Define a new Dictionary to hold the aggregated purchase information. - The key should be a string that is the full company name.
 * The value will be the valuation of each stock (price*amount) { "General Electric": 35900, "AAPL": 8445, ... }
*/
// Iterate over the purchases and update the valuation for each stock
foreach ((string ticker, int shares, double price) purchase in purchases)
{
    // Does the company name key already exist in the report dictionary?
    // If it does, update the total valuation
    // If not, add the new key and set its value
}
