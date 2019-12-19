using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace CreditCardSubmissionVerification
{
    public class CreditCardVerifier
    {
        public string DatePrefix { get; set; }
        public string RootPath { get; set; }
        public string MyProperty { get; set; }
        public string SaveFileName { get; set; }
        public List<FileSummary> Results { get; set;}

        public CreditCardVerifier()
        {
            DatePrefix = "20191003";
            RootPath = @"G:\My Drive";
            SaveFileName = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\GDriveFinanceMaster.xlsx";
        }
        public CreditCardVerifier(string datePrefix, string rootPath, string savePath)
        {
            DatePrefix = datePrefix;
            RootPath = rootPath;
            SaveFileName = Path.Join(savePath, "CreditCardReports.xlsx");
        }
        public void PopulateData()
        {
            var excelFiles = new List<string>(Directory.EnumerateFiles(RootPath, $"{DatePrefix}-*.xlsx", SearchOption.AllDirectories));
            excelFiles = excelFiles.Where(x => !x.Contains("Karla")).ToList();
            var excelList = excelFiles.Select(x => new FileSummary(x)).ToList();


            var excelRegExpress = @".*\b(?:(?!Karla)\w)+\b.*\d{8}.*\d{6}.*xlsx";
            var filteredExcelFiles = excelFiles.Where(x => Regex.IsMatch(x, excelRegExpress)).ToList();


            // find pdf files for CC number if it exists
            var pdfFiles = new List<string>(Directory.EnumerateFiles(RootPath, $"{DatePrefix}*.pdf", SearchOption.AllDirectories));
            var pdfRegExpression = @"\d{8}.*\d{6}.*pdf";
            var filteredFiles = pdfFiles.Where(x => Regex.IsMatch(x, pdfRegExpression)).ToList();

            excelList.ForEach(file =>
            {
                var pdfFileName = filteredFiles.Where(x => x.Contains(file.CreditCardNumber)).FirstOrDefault();
                file.AddPdfFile(pdfFileName);
            });

            // sort list
            Results = excelList.OrderBy(x => x.HasBothPdfAndExcel).ThenBy(x => x.CreditCardNumber).ToList();
        }
        public void CreateExcelFile()
        {
            using (var p = new ExcelPackage())
            {
                //A workbook must have at least on cell, so lets add one... 
                var ws = p.Workbook.Worksheets.Add("Results");
                //Create Heading
                ws.Cells[1, 1].Value = "CreditCreditCardNumber";
                ws.Cells[1, 2].Value = "HasBothPdfAndExcel";
                ws.Cells[1, 3].Value = "ExcelFileName";
                ws.Cells[1, 4].Value = "PdfFileName";
                ws.Cells[1, 5].Value = "ExcelFilePath";
                ws.Cells[1, 6].Value = "PdfFilePath";

                //create records
                var currentRow = 2;
                Results.ForEach(result =>
                {
                    ws.Cells[currentRow, 1].Value = result.CreditCardNumber;
                    ws.Cells[currentRow, 2].Value = result.HasBothPdfAndExcel;
                    ws.Cells[currentRow, 3].Value = result.ExcelFileName; 
                    ws.Cells[currentRow, 4].Value = result.PdfFileName;
                    ws.Cells[currentRow, 5].Value = result.ExcelFilePath;
                    ws.Cells[currentRow, 6].Value = result.PdfFilePath;
                    currentRow++;
                });

                ws.Cells.AutoFitColumns();
                //Save the new workbook. We haven't specified the filename so use the Save as method.
                p.SaveAs(new FileInfo(SaveFileName));
            }
        }
    }
    public class FileSummary
    {
        public string PdfFileName { get; set; }
        public string PdfFilePath { get; set; }
        public string ExcelFileName { get; set; }
        public string ExcelFilePath { get; set; }
        public string CreditCardNumber { get; set; }
        public bool HasBothPdfAndExcel { get { return ExcelFilePath.Equals(PdfFilePath); } }

        public FileSummary(string excelFullFileNamePath)
        {
            var (fileName, filePath) = getFileNameAndFilePathSplit(excelFullFileNamePath);
            ExcelFileName = fileName;
            ExcelFilePath = filePath;
            CreditCardNumber = getCreditCardNumberFromFileName(ExcelFileName);

        }
        public void AddPdfFile(string pdfFileName)
        {
            if (String.IsNullOrEmpty(pdfFileName))
                return;

            var (fileName, filePath) = getFileNameAndFilePathSplit(pdfFileName);
            PdfFileName = fileName;
            PdfFilePath = filePath;
        }
        private Tuple<string, string> getFileNameAndFilePathSplit(string fullPath)
        {
            var array = fullPath.Split("\\");
            var fileName = array.Last();
            var path = fullPath.Substring(0, fullPath.Length - fileName.Length);
            return new Tuple<string, string>(fileName, path);
        }

        private string getCreditCardNumberFromFileName(string fileName)
        {
            var regExpress = @"\d{8}.*(\d{6})";
            //var results = Regex.Matches(fileName, regExpress);
            var result = Regex.Match(fileName, regExpress);
            return result.Success ? result.Groups[1].Value : "XXXXXX";
            //return results[results.Count - 1].Value; //first match is going to be 8 digit date prefix and second amtch should be the 6 digit CC
        }
    }
}
