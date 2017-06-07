using MinhasTarefas.Database;
using SQLite.Net;
using MinhasTarefas.Droid.Database;
using System.IO;
using SQLite.Net.Platform.XamarinAndroid;

[assembly: Xamarin.Forms.Dependency(typeof(DatabaseAndroid))]
namespace MinhasTarefas.Droid.Database
{
    public class DatabaseAndroid : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            var nameDB = "minhasTarefas.db3";
            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), nameDB);
            return new SQLiteConnection(new SQLitePlatformAndroid(), path);
        }
    }
}