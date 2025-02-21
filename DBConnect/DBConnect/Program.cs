using DBConnect;

SiteDiaryContext createDiaryEntry = new SiteDiaryContext();

createDiaryEntry.Add(DiaryOptions.MajorDiaryOption());

createDiaryEntry.SaveChanges();

public static class DiaryOptions
{
    // Set org is to equal 1 untill db connected
    private static int organisationId = 1;

    public static DiaryEntry MajorDiaryOption() 
    {
        string location, activity, organisation, packages, trade;
        DateTime startTime, endTime;

        Console.WriteLine("Enter Start Date");
        startTime = GetUserDateAndTime();
        Console.WriteLine(startTime);

        Console.WriteLine("Enter End Date");
        endTime = GetUserDateAndTime();
        Console.WriteLine(endTime);
        
        Console.WriteLine("Enter package");
        packages = Console.ReadLine();        

        Console.WriteLine("Enter trade");
        trade = Console.ReadLine();

        Console.WriteLine("Enter location");
        location = Console.ReadLine();

        Console.WriteLine("Enter activity");
        activity = Console.ReadLine();

        // Console.WriteLine("Enter organisation");
        // organisation = Console.ReadLine();

          return new DiaryEntry
        {
            LogTypeId = 1,    // Major diary type ID
            ProjectId = 1,
            StaffId = 1,
            OrganisationId = organisationId,
            Created = DateTime.UtcNow,
            FromDatetime = startTime,
            ToDatetime = endTime,
            WorksLocation = location,
            Activity = activity,
            Description = $"Package: {packages}, Trade: {trade}" // Store trade & package in description
        };
    }

    public static DiaryEntry DiscussionOption(int id) 
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

         return new DiaryEntry
        {
            DiaryId = id,
            LogTypeId = 2,   // Discussion log type ID
            ProjectId = 1,
            StaffId = 1,
            OrganisationId = organisationId,
            Created = DateTime.UtcNow,
            FromDatetime = startTime,
            ToDatetime = endTime,
            WorksLocation = location,
            Description = details,
            Quantity = numParticipants // Using Quantity field to store participants
        };    }

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

public static class LogicUtils
{
    public static DateTime ParseDateTime (String dateInput,String time) {
        int[] parsedDateTime =  dateInput.Split('/').Select(int.Parse).ToArray();
        int[] parsedTime = time.Split(':').Select(int.Parse).ToArray();

        Console.WriteLine(parsedDateTime[0] + " " +  parsedDateTime[1]  + " " + parsedDateTime[2]);

        DateTime date = new DateTime(parsedDateTime[2], parsedDateTime[1], parsedDateTime[0], parsedTime[0], parsedTime[1], parsedTime[2] );

        return date;
    }
}