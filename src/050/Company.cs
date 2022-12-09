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
    #endregion
}