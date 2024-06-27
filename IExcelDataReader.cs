using System.Data;

namespace store
{
    internal interface IExcelDataReader
    {
        bool IsFirestRowAsColumnName { get; set; }

        DataSet AsDataSet();
    }
}