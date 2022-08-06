using NPOI.XSSF.UserModel;

namespace TideWebsiteTesting.Utitlites
    {
      public class ExcelSheet
        {


        public static void excelRead()
            {
           // String path = @"C:\Users\source\repos\SpecFlowProject1\SpecFlowProject1\Utitlites\Tide Excel Worksheet.xlsx";

            String path =  @"C:\Users\Avinash\source\repos\SpecFlowProject1\SpecFlowProject1\Utitlites\Tide Excel Worksheet.xlsx";
            XSSFWorkbook workbook = new XSSFWorkbook (File.Open (path, FileMode.Open));
            var sheet = workbook.GetSheetAt (0).GetRow (0).GetCell (0).StringCellValue.Trim ();
            Console.WriteLine (sheet);
            }
        }
    }


