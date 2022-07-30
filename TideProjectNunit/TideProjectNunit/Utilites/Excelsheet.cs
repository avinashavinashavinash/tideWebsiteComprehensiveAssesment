using NPOI.XSSF.UserModel;

namespace TideProjectNunit.Utitlites
    {
    public class ExcelSheet
        {


        public static void excelRead()
            {
         
            String path = @"C: \Users\Avinash\source\repos\TideProjectNunit\TideProjectNunit\Reports\TideExcelsheet1.xlsx";
            XSSFWorkbook workbook = new XSSFWorkbook (File.Open (path, FileMode.Open));
            var sheet = workbook.GetSheetAt (0).GetRow (0).GetCell (0).StringCellValue.Trim ();
            Console.WriteLine (sheet);
            }
        }
    }

