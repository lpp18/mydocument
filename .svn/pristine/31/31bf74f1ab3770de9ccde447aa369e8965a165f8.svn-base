using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;

namespace ApplicationModel
{
    public class Excel
    {
        public static MemoryStream WriteDataToExcel(DataSet ds)
        {
            MemoryStream memoryStream = new MemoryStream();

            try
            {
                HSSFWorkbook workbook = new HSSFWorkbook();

                foreach (DataTable table in ds.Tables)
                {
                    ISheet sheet = workbook.CreateSheet(table.TableName);
                    IRow headerRow = sheet.CreateRow(0);

                    foreach (DataColumn column in table.Columns)
                    {
                        headerRow.CreateCell(column.Ordinal).SetCellValue(column.ColumnName);
                    }

                    int rowIndex = 1;

                    foreach (DataRow row in table.Rows)
                    {
                        IRow dataRow = sheet.CreateRow(rowIndex);

                        foreach (DataColumn column in table.Columns)
                        {
                            dataRow.CreateCell(column.Ordinal).SetCellValue(row[column].ToString());
                        }

                        rowIndex++;
                    }

                    sheet = null;
                    headerRow = null;
                }

                workbook.Write(memoryStream);

                workbook = null;
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return memoryStream;
        }

        public static DataSet ExcelToDataSet(string excelPath)
        {
            return ExcelToDataSet(excelPath, true);
        }

        public static DataSet ExcelToDataSet(string excelPath, bool firstRowAsHeader)
        {
            int sheetCount;
            return ExcelToDataSet(excelPath, firstRowAsHeader, out sheetCount);
        }

        public static DataSet ExcelToDataSet(string excelPath, bool firstRowAsHeader, out int sheetCount)
        {
            using (DataSet ds = new DataSet())
            {
                using (FileStream fileStream = new FileStream(excelPath, FileMode.Open, FileAccess.Read))
                {
                    HSSFWorkbook workbook = new HSSFWorkbook(fileStream);

                    HSSFFormulaEvaluator evaluator = new HSSFFormulaEvaluator(workbook);

                    sheetCount = workbook.NumberOfSheets;

                    for (int i = 0; i < sheetCount; ++i)
                    {
                        HSSFSheet sheet = workbook.GetSheetAt(i) as HSSFSheet;
                        DataTable dt = ExcelToDataTable(sheet, evaluator, firstRowAsHeader);
                        ds.Tables.Add(dt);
                    }

                    return ds;
                }
            }
        }

        public static DataTable ExcelToDataTable(string excelPath, string sheetName)
        {
            return ExcelToDataTable(excelPath, sheetName, true);
        }

        public static DataTable ExcelToDataTable(string excelPath, string sheetName, bool firstRowAsHeader)
        {
            using (FileStream fileStream = new FileStream(excelPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                IWorkbook workbook = null;
                IFormulaEvaluator evaluator = null;
                ISheet sheet = null;
                if (excelPath.EndsWith(".xls"))
                {
                    workbook = new HSSFWorkbook(fileStream);
                    evaluator = new HSSFFormulaEvaluator(workbook);
                    sheet = workbook.GetSheet(sheetName) as HSSFSheet;
                    if (sheet == null)
                    {
                        sheet = workbook.GetSheetAt(0);
                    }
                }
                else
                {
                    workbook = new XSSFWorkbook(fileStream);
                    evaluator = new XSSFFormulaEvaluator(workbook);
                    sheet = workbook.GetSheet(sheetName) as XSSFSheet;
                    if (sheet == null)
                    {
                        sheet = workbook.GetSheetAt(0);
                    }
                }

                return ExcelToDataTable(sheet, evaluator, firstRowAsHeader);
            }
        }

        private static DataTable ExcelToDataTable(ISheet sheet, IFormulaEvaluator evaluator, bool firstRowAsHeader)
        {
            if (firstRowAsHeader)
            {
                return ExcelToDataTableFirstRowAsHeader(sheet, evaluator);
            }
            else
            {
                return ExcelToDataTable(sheet, evaluator);
            }
        }

        private static DataTable ExcelToDataTableFirstRowAsHeader(ISheet sheet, IFormulaEvaluator evaluator)
        {
            using (DataTable dt = new DataTable())
            {
                IRow firstRow = sheet.GetRow(0) as IRow;
                int cellCount = GetCellCount(sheet);

                for (int i = 0; i < cellCount; i++)
                {
                    if (firstRow.GetCell(i) != null)
                    {
                        firstRow.GetCell(i).SetCellType(CellType.String); //将表头中纯数字类型转化为Stringg类型。
                        dt.Columns.Add(firstRow.GetCell(i).StringCellValue ?? string.Format("F{0}", i + 1), typeof(string));
                    }
                    else
                    {
                        dt.Columns.Add(string.Format("F{0}", i + 1), typeof(string));
                    }
                }

                for (int i = 1; i <= sheet.LastRowNum; i++)
                {
                    IRow row = sheet.GetRow(i) as IRow;
                    DataRow dr = dt.NewRow();
                    FillDataRowByHSSFRow(row, evaluator, ref dr);
                    dt.Rows.Add(dr);
                }

                dt.TableName = sheet.SheetName;
                return dt;
            }
        }

        private static DataTable ExcelToDataTable(ISheet sheet, IFormulaEvaluator evaluator)
        {
            using (DataTable dt = new DataTable())
            {
                if (sheet.LastRowNum != 0)
                {
                    int cellCount = GetCellCount(sheet);

                    for (int i = 0; i < cellCount; i++)
                    {
                        dt.Columns.Add(string.Format("F{0}", i), typeof(string));
                    }

                    for (int i = 0; i < sheet.FirstRowNum; ++i)
                    {
                        DataRow dr = dt.NewRow();
                        dt.Rows.Add(dr);
                    }

                    for (int i = sheet.FirstRowNum; i <= sheet.LastRowNum; i++)
                    {
                        IRow row = sheet.GetRow(i) as IRow;
                        DataRow dr = dt.NewRow();
                        FillDataRowByHSSFRow(row, evaluator, ref dr);
                        dt.Rows.Add(dr);
                    }
                }

                dt.TableName = sheet.SheetName;
                return dt;
            }
        }

        private static void FillDataRowByHSSFRow(IRow row, IFormulaEvaluator evaluator, ref DataRow dr)
        {
            if (row != null)
            {
                for (int j = 0; j < dr.Table.Columns.Count; j++)
                {
                    ICell cell = row.GetCell(j) as ICell;

                    if (cell != null)
                    {
                        switch (cell.CellType)
                        {
                            case CellType.Blank:
                                dr[j] = DBNull.Value;
                                break;
                            case CellType.Boolean:
                                dr[j] = cell.BooleanCellValue;
                                break;
                            case CellType.Numeric:
                                if (DateUtil.IsCellDateFormatted(cell))
                                {
                                    dr[j] = cell.DateCellValue;
                                }
                                else
                                {
                                    dr[j] = cell.NumericCellValue;
                                }
                                break;
                            case CellType.String:
                                dr[j] = cell.StringCellValue;
                                break;
                            case CellType.Error:
                                dr[j] = cell.ErrorCellValue;
                                break;
                            case CellType.Formula:
                                cell = evaluator.EvaluateInCell(cell) as ICell;
                                dr[j] = cell.ToString();
                                break;
                            default:
                                throw new NotSupportedException(string.Format("Catched unhandle CellType[{0}]", cell.CellType));
                        }
                    }
                }
            }
        }

        private static int GetCellCount(ISheet sheet)
        {
            int firstRowNum = sheet.FirstRowNum;

            int cellCount = 0;

            for (int i = sheet.FirstRowNum; i <= sheet.LastRowNum; ++i)
            {
                IRow row = sheet.GetRow(i) as IRow;

                if (row != null && row.LastCellNum > cellCount)
                {
                    cellCount = row.LastCellNum;
                }
            }

            return cellCount;
        }


        public static MemoryStream RenderToExcel(DataTable table, string[] Columns)
        {
            MemoryStream ms = new MemoryStream();

            using (table)
            {
                IWorkbook workbook = new HSSFWorkbook();
                ISheet sheet = workbook.CreateSheet("Sheet1");
                IRow headerRow = sheet.CreateRow(0);

                sheet.SetColumnWidth(2, 40 * 256);
                sheet.SetColumnWidth(3, 40 * 256);
                sheet.SetColumnWidth(4, 15 * 256);
                sheet.SetColumnWidth(5, 40 * 256);
                sheet.SetColumnWidth(6, 15 * 256);
                sheet.SetColumnWidth(9, 20 * 256);

                // handling header.
                for (int i = 0; i < Columns.Length; i++)
                {
                    headerRow.CreateCell(i).SetCellValue(Columns[i]);//If Caption not set, returns the ColumnName value
                }
                // handling value.
                int rowIndex = 1;

                foreach (DataRow row in table.Rows)
                {
                    IRow dataRow = sheet.CreateRow(rowIndex);

                    foreach (DataColumn column in table.Columns)
                    {
                        dataRow.CreateCell(column.Ordinal).SetCellValue(row[column].ToString());
                    }

                    rowIndex++;
                }

                workbook.Write(ms);
                ms.Flush();
                ms.Position = 0;

            }
            return ms;
        }

        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="ms"></param>
        /// <param name="pathFileName"></param>
        public static void SaveToFile(DataTable dt, string[] Columns, string pathFileName)
        {

            MemoryStream ms = RenderToExcel(dt, Columns);
            using (FileStream fs = new FileStream(pathFileName, FileMode.Create, FileAccess.Write))
            {
                byte[] data = ms.ToArray();

                fs.Write(data, 0, data.Length);
                fs.Flush();
                data = null;
            }
        }



    }
}