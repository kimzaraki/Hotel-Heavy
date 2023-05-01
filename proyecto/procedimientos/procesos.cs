using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SqlClient;
using RestSharp;
using System.Net;
using sck = System.Net.Sockets.Socket;
using System.Diagnostics;
using System.Net.Sockets;
using Krypton.Toolkit;

namespace proyecto.procedimientos
{
    internal class rest
    {
        public static string consume(string url)
        {
                var client = new RestClient(url);
                var request = new RestRequest();
                RestResponse response = client.Execute(request);
                if (response.Content == null) return "3";
                return response.Content.ToString();
        }
    }

    internal class limpieza
    {
        public static void limpiar(Panel p, DataGridView d)
        {foreach (Control c in p.Controls)if (c is TextBox tb)tb.Clear();
            else if (c is KryptonTextBox t) { t.Clear();}
            d.Rows.Clear(); }
        public static void limpiar(Panel p)
        {foreach (Control c in p.Controls) if (c is KryptonTextBox tb) tb.Clear();}
    }
}
