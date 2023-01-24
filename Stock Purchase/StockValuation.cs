namespace Stock_Purchase;

public class StockValuation
{
    //This is in another data structure. should it even be in here?
    private double _totalCurrentStockValue;
    private double _gainLoss;


    public double TotalCurrentStockValue
    {
        get => Math.Round(_totalCurrentStockValue, 2);
        set => _totalCurrentStockValue = value;
    }
    public double GainLoss { 
        get => Math.Round(_gainLoss, 2);
        set => _gainLoss = value;
    }

    public int TotalShares { get; set; }
    
    override public string  ToString()
    {
        return $"Total Stock Value: {TotalCurrentStockValue}, Gain/Loss: {GainLoss}, TotalShares: {TotalShares}";
    }
}
