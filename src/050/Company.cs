using static MonthName;
public class Company
{
    #region Properties and Fields
    public string Name { get; set; }
    public string City { get; set; }
    public bool IsIncorpated { get; set; }
    public DateTime BusinessStartDate { get; private set; }
    public decimal? GrossIncomeToDate { get; private set; }

    public MonthName YearEndMonth { get; private set; } = MonthName.Dec;
    //     ^-------^ ^----------^                         ^-----------^
    //       |          |_ Variable                         |_ Value
    //       |_ Data Type
    public int YearEndDay {get; private set; } = 31;
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

    public bool IsOpen(DateTime onDate)
    {
        bool open = true;
        // Closed on the weekend!
        if(onDate.DayOfWeek == DayOfWeek.Saturday || onDate.DayOfWeek == DayOfWeek.Sunday)
            open = false;

        return open;
    }

    public void SetFiscalYearEnd(MonthName month, int day)
    {
        // Perform validation in a private method
        Validate(month, day);
        YearEndDay = day;
        YearEndMonth = month;
    }

    public int DaysRemainingInFiscalYear(DateTime fromDate)
    {
        int count = -1; // initial value is just to get red squiggles removed
        int endMonth = (int) YearEndMonth; // casting to get the underlying int value
        int sameFiscalYear = fromDate.Year;
        if(fromDate.Month > endMonth || (fromDate.Month == endMonth && fromDate.Day >= YearEndDay))
            sameFiscalYear ++; // add one

        DateTime prospectiveYearEnd = new DateTime(sameFiscalYear, endMonth, YearEndDay);

        TimeSpan difference = prospectiveYearEnd - fromDate;
        //       ^--------^   ^----------------^   ^------^
        //        TimeSpan         DateTime      - DateTime

        // Note: I lose a "fraction" of a day, but that's not important for this method
        count = (int) difference.TotalDays;
        return count;
    }


    private void Validate(MonthName month, int day)
    {
        // See https://www.timeanddate.com/calendar/months/
        // bool isBadMonthAndDay = true;
        bool isValidMonthAndDay = false;

        // Try to prove it is an acceptable month/day
        if(day <= 28 && month == Feb)
            isValidMonthAndDay = true;
        else if(day <= 31 && (month == Jan || month == Mar || month == May || month == Jul || month == Aug || month == Oct || month == Dec))
            isValidMonthAndDay = true;
        else if(day <= 30 && month != Unknown)
            isValidMonthAndDay = true;
        if(!isValidMonthAndDay) throw new ArgumentOutOfRangeException();
    }

    public override string ToString()
    {
        return $"{Name} (located in {City}) was founded in {BusinessStartDate.ToShortDateString()}";
    }
    #endregion
}