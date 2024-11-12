using IQApp.DataAccess.Entities;
using SQLite;

namespace IQApp.DataAccess.Concrete
{
    public class LocalDbService : IDisposable
    {
        private const string Db_name = "IqDbApp";
        private readonly SQLiteConnection _connection;
        public SQLiteConnection Connection { get { return _connection; } }

        public LocalDbService()
        {
            _connection = new SQLiteConnection(Path.Combine(FileSystem.AppDataDirectory, Db_name));
            _connection.CreateTable<Question>();
        }

        public void Dispose()
        {
            _connection.Dispose();
        }
    }
}
