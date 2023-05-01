using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.reports
{
    internal class navegador : KryptonPanel
    {
        public EO.WebBrowser.WebView browsah;
        private EO.WinForm.WebControl webControl1;

        public navegador()
        {
            iniciar();
            this.Controls.Add(webControl1);
            this.Size = new System.Drawing.Size(800, 500);
            this.Location = new System.Drawing.Point(10, 30);
        }
        void iniciar()
        {
            this.browsah = new EO.WebBrowser.WebView();
            this.webControl1 = new EO.WinForm.WebControl();
            // 
            // webControl1
            // 
            this.webControl1.BackColor = System.Drawing.Color.White;
            this.webControl1.Location = new System.Drawing.Point(0, 0);
            this.webControl1.Name = "webControl1";
            this.webControl1.Size = new System.Drawing.Size(800, 500);
            this.webControl1.TabIndex = 18;
            this.webControl1.Text = "webControl1";
            this.webControl1.WebView = this.browsah;
        }
    }
}
