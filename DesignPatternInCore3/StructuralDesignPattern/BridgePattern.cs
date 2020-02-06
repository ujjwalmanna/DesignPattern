using System;

namespace StructuralDesignPattern
{
    public interface IBridgeManager
    {
        void SaveData(string data, string dataType);
    }

    public abstract class SaveData
    {
        public IBridgeManager IBridgeManager;
        public abstract void Save(string data);
    }

    public class SaveSqlData : SaveData
    {
        public override void Save(string data)
        {
            IBridgeManager.SaveData(data, "SQL");
        }
    }
    public class SaveOracleData : SaveData
    {
        public override void Save(string data)
        {
            IBridgeManager.SaveData(data, "Oracle");
        }
    }

    public class OracleDataHandler : IBridgeManager
    {
        public void SaveData(string data, string dataType)
        {
            Console.WriteLine($"{data} is saved through oracle");
        }
    }

    public class SqlDataHandler : IBridgeManager
    {
        public void SaveData(string data, string dataType)
        {
            Console.WriteLine($"{data} is saved through sql");
        }
    }
}
