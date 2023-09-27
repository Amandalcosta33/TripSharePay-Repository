using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace TripSharePay_Repository.Data
{
    public class DataTables1
    {
         public static DataTable CreateDatatable(string[] ArrayColumns, string DataTableName, string UniqueColumn = "")
        {
            try
            {
                DataTable mDataTable = new DataTable(DataTableName);
                DataColumn mDataColumn;

                foreach (string Column in ArrayColumns)
                {
                    mDataColumn = new DataColumn();
                    mDataColumn.DataType = Type.GetType("System.String");
                    mDataColumn.ColumnName = Column;
                    if (UniqueColumn == Column)
                        mDataColumn.Unique = true;
                    mDataTable.Columns.Add(mDataColumn);
                }
                return mDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable CreateDatatable(List<string[]> ArrayColumns, string DataTableName, string UniqueColumn = "")
        {
            try
            {
                DataTable mDataTable = new DataTable(DataTableName);
                DataColumn mDataColumn;

                foreach (string[] Column in ArrayColumns)
                {
                    mDataColumn = new DataColumn();
                    mDataColumn.DataType = Type.GetType(Column[1]);
                    mDataColumn.ColumnName = Column[0];
                    if (UniqueColumn == Column[0])
                        mDataColumn.Unique = true;
                    mDataTable.Columns.Add(mDataColumn);
                }
                return mDataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void InsertDatatable(string[] ArrayColumnsValues, ref DataTable Returntable, bool AutoIncrementColumn = false)
        {
            try
            {
                DataRow linha;
                linha = Returntable.NewRow();
                if (AutoIncrementColumn)
                    for (int i = 1; i <= ArrayColumnsValues.Length; i++)
                        linha[i] = Convert.ChangeType(ArrayColumnsValues[i - 1], Type.GetType("System.String"));
                else
                    for (int i = 0; i < ArrayColumnsValues.Length; i++)
                        linha[i] = Convert.ChangeType(ArrayColumnsValues[i], Type.GetType("System.String"));

                Returntable.Rows.Add(linha);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void InsertDatatable(List<string[]> ArrayColumnsValues, ref DataTable Returntable, bool AutoIncrementColumn = false)
        {
            try
            {
                DataRow linha;
                linha = Returntable.NewRow();
                if (AutoIncrementColumn)
                    for (int i = 1; i <= ArrayColumnsValues.Count; i++)
                        linha[i] = Convert.ChangeType(ArrayColumnsValues[i - 1][0], Type.GetType(ArrayColumnsValues[i - 1][1]));
                else
                    for (int i = 0; i < ArrayColumnsValues.Count; i++)
                    {
                        if(ArrayColumnsValues[i][0] == "")
                            linha[i] = DBNull.Value;
                        else
                            linha[i] = Convert.ChangeType(ArrayColumnsValues[i][0], Type.GetType(ArrayColumnsValues[i][1]));

                    }
                        

                Returntable.Rows.Add(linha);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}