using Utils;
namespace DailyDiary;
public static class DiaryOptions
{
    public static Diary MajorDiaryOption(int id) 
    {
        string location, activity, org, packages, trade;
        DateTime startTime, endTime;

        Console.WriteLine("Enter Start Date");
        startTime = GetUserDateAndTime();
        Console.WriteLine(startTime);

        Console.WriteLine("Enter End Date");
        endTime = GetUserDateAndTime();
        Console.WriteLine(endTime);

        Console.WriteLine("Enter organisation");
        org = Console.ReadLine();
        
        Console.WriteLine("Enter package");
        packages = Console.ReadLine();        

        Console.WriteLine("Enter trade");
        trade = Console.ReadLine();

        Console.WriteLine("Enter location");
        location = Console.ReadLine();

        Console.WriteLine("Enter activity");
        activity = Console.ReadLine();

        return new MajorConstructionDiary(id, DateTime.UtcNow, location, activity, startTime, endTime, org, trade, packages);
    }

    public static Diary DiscussionOption(int id) 
    {
        string location, details;
        DateTime startTime, endTime;
        int numParticipants;

        Console.WriteLine("Enter Start Date");
        startTime = GetUserDateAndTime();
        Console.WriteLine(startTime);

        Console.WriteLine("Enter End Date");
        endTime = GetUserDateAndTime();
        Console.WriteLine(endTime);

        Console.WriteLine("Enter location");
        location = Console.ReadLine();

        Console.WriteLine("Enter details");
        details = Console.ReadLine();

        Console.WriteLine("Enter number of participants");
        numParticipants = int.Parse(Console.ReadLine());

        return new Discussions(id, location, DateTime.UtcNow, startTime, endTime, details, numParticipants);
    }

    private static DateTime GetUserDateAndTime() 
    {
        Console.WriteLine("Enter date in format DD/MM/YYYY");
        var dateInput = Console.ReadLine();

        Console.WriteLine("Enter time in format HH:MM:SS (e.g. 14:30:00):");
        var timeInput = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(dateInput) || string.IsNullOrWhiteSpace(timeInput))
        {
            Console.WriteLine("Invalid Date/Time");
            return DateTime.MinValue;
        }

        try 
        {  
            return LogicUtils.ParseDateTime(dateInput, timeInput);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error parsing date/time: {ex.Message}");
            return DateTime.MinValue;
        }
    }
}
