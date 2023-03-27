using System.Collections.Generic;
using System.Threading.Tasks;
using GemBox.Spreadsheet;

List<Task> TaskList = new List<Task>();
SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
for (int i = 0; i < 10; i++)
{
    var task = Task.Run(async () =>
    {
        var file = ExcelFile.Load("Template.xlsx");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                file.Worksheets[0].Cells[i, j].SetValue("<html>Test</html>", new HtmlLoadOptions {});
            }
        }
    });
    TaskList.Add(task);
}
await Task.WhenAll(TaskList);
return 1;


