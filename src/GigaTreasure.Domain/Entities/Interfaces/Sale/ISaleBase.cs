namespace GigaTreasure.Domain.Entities.Interfaces.Sale;

public interface ISaleBase
{
    public DateTime Date { get; set; }
    public decimal FinalAmount { get; set; }
}