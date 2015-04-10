
    //Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
    //Find in Google how to download files in C#.
    //Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;
class DownloadFile
{
    static void Main()
    {
        try
        {
            using (WebClient web = new WebClient())
            {
                web.DownloadFile(@"http://telerikacademy.com/Content/Images/news-img01.png", "TelerikNinja.png");
                //the picture should be saved in the bin directory of the project.
            }
        }
        catch (UnauthorizedAccessException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (NotSupportedException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (WebException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (ArgumentException exception)
        {
            Console.WriteLine(exception.Message);
        }
        finally
        {

        }
    }
}