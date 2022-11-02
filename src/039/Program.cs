using static System.Console;
// .csv - Comma-Separated-Values
const string COLUMN_NAMES = "CourseNumber,Section,CourseName";
// Ask the user for a file name
//  - string PromptFileName()
// If the file does not exist, then
//  create it as a .csv with the column names
//  - void CreateFile(string)
// Else
//  then display the existing courses
//  - void DisplayFileContents(string)
// Proceed to ask the user how many classes they want to add to the file.
//  - int PromptForNumber(string message)
// Get each course's details and write as a .csv row of data
//  - void WriteRowOfData(string fileName)
    string courseNumber = GetInfo("Enter the course number of a class you are in: ");
    string section = GetInfo("Enter the section #");
    string courseName = GetInfo("Enter the course name");


string GetInfo(string promptMessage)
{
    Write(promptMessage);
    string info = ReadLine();
    while(string.IsNullOrWhiteSpace(info))
    {
        Write("\tTry again: ");
        info = ReadLine();
    }
    return info.Trim(); // Clean out the leading and trailing whitespace
}
