namespace CoreDemo.Models.Contacts;

public class RevenueJournalSumDto
{
    /// <summary>
    /// Total sum of payment for all the revenues
    /// </summary>
    public decimal TotalPayment { get; set; }

    /// <summary>
    /// Total sum of purchase price for all the revenues
    /// </summary>
    public decimal TotalPurchasePrice { get; set; }
}
