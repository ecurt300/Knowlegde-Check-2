using Knowledge_Check_2;
namespace Testing
{
    [TestClass]
    public sealed class Test1
    {

        //Test method to check if I know how unit tests work.
        [TestMethod]
        public void DisplayPrintData()
        {
            var repository = new ChildObj();
            var data = repository.Data;
            Assert.IsNotNull(repository);
            Console.WriteLine(data);
        }
        //True useful Unit Test
        [TestMethod]
        public void DisplayRecords()
        {
            List<ChildObj> records = new List<ChildObj>();
            for (int i = 0; i < 10; i++)
            {
                var record = new ChildObj();
                record.ID = i;
                record.Data = $"{record.ID} --ID {record.Data} --{i} Data ";
                            
            }

            foreach (var record in records)
            {
               Assert.AreEqual(record.ToString(), $"{record.ID} --ID {record.Data} {record.ID} --Data ");
            }


        }
    }
}
