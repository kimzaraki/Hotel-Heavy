using PuppeteerSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.reports
{
    internal class topdf
    {
        public topdf(string url, string path)
        {generar(url, path);}
        public async Task generar(string url, string pdfPath)
        {
            await new BrowserFetcher().DownloadAsync(BrowserFetcher.DefaultRevision);

            var launchOptions = new LaunchOptions
            {
                Headless = true
            };

            using (var browser = await Puppeteer.LaunchAsync(launchOptions))
            using (var page = await browser.NewPageAsync())
            {
                await page.GoToAsync(url);
                await page.PdfAsync(pdfPath);
            }
        }
    }
}
