using static System.Console;

WriteLine("Hello, World!");

Company myOldCompany = 
    new Company("Dynamic Delivery", "Edmonton", new DateTime(1992, 1, 12));

myOldCompany.ReportNewEarnings(25000m);
// public void ReportNewEarnings(decimal earnings)

Company currentBusiness = 
    new Company("Dynamic Generation Inc.", "Edmonton", new DateTime(2005, 2, 15), true);


