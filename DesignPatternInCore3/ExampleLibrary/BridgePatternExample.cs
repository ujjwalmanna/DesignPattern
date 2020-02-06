using System;
using System.Collections.Generic;
using System.Text;
using StructuralDesignPattern;

namespace ExampleLibrary
{
    public class BridgePatternExample:IExample
    {
        
        public void PrintResult()
        {
            SaveData _saveData = new SaveOracleData
            {
                IBridgeManager = new OracleDataHandler()
            };
            _saveData.Save("sample oracle sql data");
            _saveData.IBridgeManager=new SqlDataHandler();
            _saveData.Save("saving oracle sql data");

            _saveData = new SaveSqlData
            {
                IBridgeManager = new SqlDataHandler()
            };
            _saveData.Save("another sql data");
            _saveData.IBridgeManager = new OracleDataHandler();
            _saveData.Save("another oracle sql data");
        }
    }
}
