using System;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using PuppeteerSharp;

namespace PuppeteerSharpPdfDemo
{
    class MainClass
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Downloading browsers");

            using var browserFetcher = new BrowserFetcher(SupportedBrowser.Chrome);
            var chrome118 = await browserFetcher.DownloadAsync("118.0.5993.70");
            var chrome119 = await browserFetcher.DownloadAsync("119.0.5997.0");

            Console.WriteLine("Navigating");
            await using (var browser = await Puppeteer.LaunchAsync(new()
                         {
                             ExecutablePath = chrome118.GetExecutablePath(),
                         }))
            {
                await using var page = await browser.NewPageAsync();
                await page.GoToAsync("https://www.whatismybrowser.com/");

                Console.WriteLine("Generating PDF");
                await page.PdfAsync(Path.Combine(Directory.GetCurrentDirectory(), "118.pdf"));

                Console.WriteLine("Export completed");
            }

            await using (var browser = await Puppeteer.LaunchAsync(new()
                         {
                             ExecutablePath = chrome119.GetExecutablePath(),
                         }))
            {
                await using var page = await browser.NewPageAsync();
                await page.GoToAsync("https://www.whatismybrowser.com/");

                Console.WriteLine("Generating PDF");
                await page.PdfAsync(Path.Combine(Directory.GetCurrentDirectory(), "119.pdf"));

                Console.WriteLine("Export completed");
            }
        }
    }
}
