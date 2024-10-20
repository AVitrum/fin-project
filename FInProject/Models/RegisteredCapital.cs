namespace FInProject.Models;

public class RegisteredCapital : BaseModel
{
    public RegisteredCapital() : base("I. Власний капітал")
    {
        PaidInCapital = new Asset(1400, "Зареєстрований (пайовий) капітал");
        RevaluationReserve = new Asset(1405, "Капітал у дооцінках");
        AdditionalCapital = new Asset(1410, "Додатковий капітал");
        ReserveCapital = new Asset(1415, "Резервний капітал");
        RetainedEarnings = new Asset(1420, "Нерозподілений прибуток (непокритий збиток)");
        UnpaidCapital = new Asset(1425, "Неоплачений капітал");
        WithdrawnCapital = new Asset(1430, "Вилучений капітал");
        Sum = new Asset(1495, "Усього за розділом I");
    }

    public Guid PaidInCapitalId { get; set; }
    public Asset PaidInCapital { get; set; }

    public Guid RevaluationReserveId { get; set; }
    public Asset RevaluationReserve { get; set; }

    public Guid AdditionalCapitalId { get; set; }
    public Asset AdditionalCapital { get; set; }

    public Guid ReserveCapitalId { get; set; }
    public Asset ReserveCapital { get; set; }

    public Guid RetainedEarningsId { get; set; }
    public Asset RetainedEarnings { get; set; }

    public Guid UnpaidCapitalId { get; set; }
    public Asset UnpaidCapital { get; set; }

    public Guid WithdrawnCapitalId { get; set; }
    public Asset WithdrawnCapital { get; set; }

    public Guid SumId { get; set; }
    public Asset Sum { get; set; }
}