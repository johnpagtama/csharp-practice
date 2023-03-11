using System;
using System.IO;

namespace ExamplesLibrary.Files
{
    public class ExampleFileHandler
    {
        public static void ReadFile()
        {
            string dittoPath = @"C:\Users\pagta\Downloads\ditto.txt";

            string stringizardPath = @"C:\Users\pagta\Downloads\stringizard.txt";

            string dittoData;

            string stringizardData;

            FileStream dittoStream = new FileStream(dittoPath, FileMode.Open, FileAccess.Read);

            using (StreamReader streamReader = new StreamReader(dittoStream))
            {
                dittoData = streamReader.ReadToEnd();
            }

            Console.WriteLine(dittoData.Replace("M", " "));

            FileStream stringizardStream = new FileStream(stringizardPath, FileMode.Open, FileAccess.Read);

            using (StreamReader streamReader1 = new StreamReader(stringizardStream))
            {
                stringizardData = streamReader1.ReadToEnd();
            }

            Console.WriteLine(stringizardData.Replace("M", " "));
        }
    }
}
