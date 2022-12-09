public class Company
{
    #region Properties and Fields
    public string Name { get; set; }
    public string City { get; set; }
    public bool IsIncorpated { get; set; }
    public DateTime BusinessStartDate { get; private set; }
    public decimal? GrossIncomeToDate { get; private set; }
    #endregion

    #region Constructor(s)
    public Company(string name, string city, DateTime businessStart, bool isIncorpated = false)
    {
        Name = name;
        City = city;
        BusinessStartDate = businessStart;
        IsIncorpated = isIncorpated;
    }
    #endregion

    #region Methods
    public void ReportNewEarnings(decimal earnings)
    {
        // I will store this in the Gross Income to date
        // NOTE: my property is a "nullable" type - decimal?
        //       All nullable types have the property .HasValue
        if(GrossIncomeToDate.HasValue)
            GrossIncomeToDate += earnings;
        else
            GrossIncomeToDate = earnings;
    }

    public override string ToString()
    {
        return $"{Name} (located in {City}) was founded in {BusinessStartDate.ToShortDateString()}";
    }
    #endregion
}