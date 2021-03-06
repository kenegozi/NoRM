/*
namespace NoRM.Tests
{
    [TestFixture]
    [Category("Hits MongoDB")]
    public class MongoContextTest
    {
        private Mongo _context;
        private MongoDatabase _db1;
        private MongoDatabase _db2;

        [TestFixtureSetUp]
        public void ConfigureContext()
        {
            //creates connection to the local mongo Db install on the default port.
            this._context = new Mongo();

            //create two databases.
            this._db1 = this._context.GetDatabase("Test1");
            this._db2 = this._context.GetDatabase("Test2");
        }

        [Test]
        public void GetAllDatabases_Returns_DBs()
        {

            Assert.IsNotEmpty(this._context.GetAllDatabases().ToList());
        }

        [Test]
        public void Drop_Database_Returns_True()
        {
            var dbName = "test"+Guid.NewGuid().ToString().Substring(0,5);
            var db = this._context.GetDatabase(dbName);
            //the db may not exist until we insert into it.
            db.GetCollection<MiniObject>(dbName).Insert(new MiniObject());

            Assert.IsTrue((this._context.DropDatabase(dbName).OK == 1d));
        }
        [Test]
        public void Check_Invalid_Server()
        {
            var context = new Mongo("mongodb://localhost:11111");

           // Assert.Throws(typeof(SocketException), delegate { context.Connect(); });
        }

        [Test]
        public void Check_Valid_Server()
        {
            //Assert.IsTrue(this._context.Connect());
        }

        [Test]
        public void Check_Current_Operations()
        {
            // Not sure how to test this yet.
            var server = new Mongo();

            var ops = server.GetCurrentOperations();

        }

        [Test]
        public void Check_Kill_Operation()
        {
            var response = this._context.KillOperation(1234);

            Assert.IsTrue((response.Info == "no op in progress/not locked"));
        }
    }
}
*/