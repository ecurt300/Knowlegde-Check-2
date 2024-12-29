using Knowledge_Check_2;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<MyClass>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var repository = new ChildObj();

    Console.WriteLine($"Enter the value for ID " + $" record {i}");
    repository.ID = int.Parse(Console.ReadLine());

    Console.WriteLine($"Enter the Data for {repository.ID} ");
    repository.Data = (Console.ReadLine());

    recordList.Add(repository);
}

// Print out the list of records using Console.WriteLine()
foreach (var record in recordList)
{
   
    Console.WriteLine(record.ToString());
}