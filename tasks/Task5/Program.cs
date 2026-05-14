using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        // Configuration
        string inputPath = "data.txt";
        string outputPath = "analysis_report.txt";
        static int CountWords(string textcontent)
        {
            int wordCount = 0;
            bool isInsideWord = false;

            foreach (char c in textcontent)
            {
                if (char.IsWhiteSpace(c))
                {
                    isInsideWord = false;
                }
                else
                {
                    if (!isInsideWord)
                    {
                        wordCount++;
                        isInsideWord = true;
                    }
                }
            }
            return wordCount;
        }
        try
        {
            string fileName = Path.GetFileName(inputPath);
            string content = await File.ReadAllTextAsync(inputPath);

            // Lines: Split by newline character
            int lineCount = content.Split('\n').Length;

            // Words: Split by any whitespace and remove empty results
            int wordCount = CountWords(content);

            // 3. FORMAT OUTPUT
            string report = "--- Simple File Report ---\n" +
                            $"File Name: {fileName}\n" +
                            $"Lines:     {lineCount}\n" +
                            $"Words:     {wordCount}\n" +
                            "--------------------------";

            // 4. WRITE RESULT
            await File.WriteAllTextAsync(outputPath, report);

            Console.WriteLine($"Analysis of '{fileName}' saved to {outputPath}.");
        }
        // EXCEPTION HANDLING
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: Could not find the file 'data.txt'.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error: A hardware or system issue occurred: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}