using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using PuppeteerSharp.Media;
using PuppeteerSharp.Tests.Attributes;
using PuppeteerSharp.Nunit;
using NUnit.Framework;

namespace PuppeteerSharp.Tests.ScreencastTests
{
    public class ScreencastTests : PuppeteerBrowserContextBaseTest
    {

        [PuppeteerTimeout(-1)]
        public async Task Usage()
        {using var browserFetcher = new BrowserFetcher();

            #region ScreencastUsage
            await using var browser = await Puppeteer.LaunchAsync(new LaunchOptions());
            await using var page = await browser.NewPageAsync();
            await page.GoToAsync("https://www.example.com");
            var recorder =await page.ScreencastAsync(new ScreencastOptions
            {
                Path = "recording.webm",
            });

            await recorder.StopAsync();
            #endregion
        }
    }
}
