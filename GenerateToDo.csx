using System;
using System.IO;

var d = DateTime.Now;
var location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
var todoDate = string.Format("{0}-{1}-{2}", d.Month, d.Day, d.Year);
var todoFileName = string.Format("todo{0}.md", todoDate);

var fileLocation = string.Format("{0}/{1}", location, todoFileName);
// Check if file doesn't exists
// If so Create
if (!File.Exists(fileLocation))
{
    using (StreamWriter sw = File.CreateText(fileLocation))
    {
        sw.WriteLine(string.Format("# TODO {0}", todoDate));
        sw.WriteLine(string.Empty);
        sw.WriteLine("- [ ] ");
    }
}