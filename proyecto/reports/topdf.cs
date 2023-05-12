using PuppeteerSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;



//NO TOCAR NI DE CURA, CON ESTE GENERA LOS PDF MAMALON, A MENOS QUE LE CAMBIES EL PUERTO A LA API
namespace proyecto.reports
{
    internal class topdf
    {
        public topdf(string url, string path)
        {generar(url, path);}
        public async Task generar(string url, string pdfPath)
        {
            //CAMBIA EL PUERTO DE LA URL PARA QUE SE ADAPTE EL GENERADOR PDF
            url = proyecto.procedimientos.rest.addport("http://localhost", "8000", url);
            await new BrowserFetcher().DownloadAsync(BrowserFetcher.DefaultRevision);
            //MessageBox.Show(url);
            //MessageBox.Show(pdfPath);
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
