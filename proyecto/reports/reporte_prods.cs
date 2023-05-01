using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Krypton.Toolkit;
using mt = proyecto.procedimientos;
using _rest = proyecto.procedimientos.rest;
using dinusuario = proyecto.formsu.usuario;
using iTextSharp.text.pdf.codec.wmf;

using r_prods = proyecto.reports.reporte_prods;
using proyecto.reserva;

namespace proyecto.reports
{
    //UI
    public class p_reporte : KryptonPanel
    {
        paleta p = new paleta();
        private Button b_prod_restart;
        private Krypton.Toolkit.KryptonCheckBox chk_bebidas;
        private Krypton.Toolkit.KryptonCheckBox chk_servicios;
        private Krypton.Toolkit.KryptonCheckBox chk_alimentos;
        private Krypton.Toolkit.KryptonCheckBox chk_habitaciones;
        private DataGridView tabla_prods;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn estado;
        private Button b_prod_buscar;
        private Label label4;
        private TextBox t_prods_max;
        private TextBox t_prods_min;
        private Label label6;
        private Label label7;
        private ComboBox cb_prods_estados;
        private Button b_print;

        private static p_reporte inst;
        public static p_reporte get_inst()
        {if (inst == null) inst = new p_reporte();return inst;}
        //BUILDER
        public p_reporte()
        { 
            b_prod_restart = new System.Windows.Forms.Button();
            chk_bebidas = new Krypton.Toolkit.KryptonCheckBox();
            chk_servicios = new Krypton.Toolkit.KryptonCheckBox();
            chk_alimentos = new Krypton.Toolkit.KryptonCheckBox();
            chk_habitaciones = new Krypton.Toolkit.KryptonCheckBox();
            tabla_prods = new System.Windows.Forms.DataGridView();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            b_prod_buscar = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            t_prods_max = new System.Windows.Forms.TextBox();
            t_prods_min = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            cb_prods_estados = new System.Windows.Forms.ComboBox();
            b_print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(tabla_prods)).BeginInit();
            SuspendLayout();
            // 
            // p_report_prods
            // 
            Controls.Add(b_prod_restart);
            Controls.Add(chk_bebidas);
            Controls.Add(chk_servicios);
            Controls.Add(chk_alimentos);
            Controls.Add(chk_habitaciones);
            Controls.Add(tabla_prods);
            Controls.Add(b_prod_buscar);
            Controls.Add(label4);
            Controls.Add(t_prods_max);
            Controls.Add(t_prods_min);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(cb_prods_estados);
            Controls.Add(b_print);
            Location = new System.Drawing.Point(10, 70);
            MaximumSize = new System.Drawing.Size(850, 500);
            Name = "p_report_prods";
            Padding = new System.Windows.Forms.Padding(10);
            Palette = p; PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            Size = new System.Drawing.Size(850, 500);
            TabIndex = 4;
            Visible = false;
            // 
            // b_prod_restart
            // 
            b_prod_restart.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            b_prod_restart.Location = new System.Drawing.Point(668, 20);
            b_prod_restart.Name = "b_prod_restart";
            b_prod_restart.Size = new System.Drawing.Size(129, 31);
            b_prod_restart.TabIndex = 4;
            b_prod_restart.Text = "Reiniciar 🔁";
            b_prod_restart.UseVisualStyleBackColor = true;

            // 
            // chk_bebidas
            // 
            chk_bebidas.Location = new System.Drawing.Point(710, 99);
            chk_bebidas.Name = "chk_bebidas";
            chk_bebidas.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            chk_bebidas.Size = new System.Drawing.Size(67, 17);
            chk_bebidas.StateCommon.ShortText.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            chk_bebidas.TabIndex = 8;
            chk_bebidas.Values.Text = "Bebidas";
            // 
            // chk_servicios
            // 
            chk_servicios.Location = new System.Drawing.Point(710, 76);
            chk_servicios.Name = "chk_servicios";
            chk_servicios.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            chk_servicios.Size = new System.Drawing.Size(79, 17);
            chk_servicios.StateCommon.ShortText.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            chk_servicios.TabIndex = 6;
            chk_servicios.Values.Text = "Servicios";
            // 
            // chk_alimentos
            // 
            chk_alimentos.Location = new System.Drawing.Point(555, 99);
            chk_alimentos.Name = "chk_alimentos";
            chk_alimentos.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            chk_alimentos.Size = new System.Drawing.Size(79, 17);
            chk_alimentos.StateCommon.ShortText.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            chk_alimentos.TabIndex = 7;
            chk_alimentos.Values.Text = "Alimentos";
            // 
            // chk_habitaciones
            // 
            chk_habitaciones.Location = new System.Drawing.Point(555, 76);
            chk_habitaciones.Name = "chk_habitaciones";
            chk_habitaciones.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            chk_habitaciones.Size = new System.Drawing.Size(98, 17);
            chk_habitaciones.StateCommon.ShortText.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            chk_habitaciones.TabIndex = 5;
            chk_habitaciones.Values.Text = "Habitaciones";
            // 
            // tabla_prods
            // 
            tabla_prods.BackgroundColor = System.Drawing.Color.White;
            tabla_prods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla_prods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Nombre,
            Descripcion,
            dataGridViewTextBoxColumn1,
            Categoria,
            estado});
            tabla_prods.Location = new System.Drawing.Point(0, 139);
            tabla_prods.Name = "tabla_prods";
            tabla_prods.ReadOnly = true;
            tabla_prods.RowHeadersVisible = false;
            tabla_prods.RowTemplate.Height = 25;
            tabla_prods.Size = new System.Drawing.Size(800, 223);
            tabla_prods.TabIndex = 17;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Nombre.FillWeight = 120F;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.FillWeight = 250F;
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Precio";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // estado
            // 
            estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            estado.FillWeight = 60F;
            estado.HeaderText = "Estado";
            estado.Name = "estado";
            estado.ReadOnly = true;
            // 
            // b_prod_buscar
            // 
            b_prod_buscar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            b_prod_buscar.Location = new System.Drawing.Point(527, 22);
            b_prod_buscar.Name = "b_prod_buscar";
            b_prod_buscar.Size = new System.Drawing.Size(129, 27);
            b_prod_buscar.TabIndex = 3;
            b_prod_buscar.Text = "Buscar 🔎";
            b_prod_buscar.UseVisualStyleBackColor = true;
            b_prod_buscar.Click += new EventHandler(b_prod_buscar_Click);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(23, 19);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(119, 32);
            label4.TabIndex = 14;
            label4.Text = "Filtros";
            // 
            // t_prods_max
            // 
            t_prods_max.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            t_prods_max.Location = new System.Drawing.Point(409, 20);
            t_prods_max.Name = "t_prods_max";
            t_prods_max.PlaceholderText = "MAX >>>";
            t_prods_max.Size = new System.Drawing.Size(100, 23);
            t_prods_max.TabIndex = 1;
            // 
            // t_prods_min
            // 
            t_prods_min.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            t_prods_min.Location = new System.Drawing.Point(287, 20);
            t_prods_min.Name = "t_prods_min";
            t_prods_min.PlaceholderText = "MIN <<<";
            t_prods_min.Size = new System.Drawing.Size(100, 23);
            t_prods_min.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(230, 32);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(49, 15);
            label6.TabIndex = 11;
            label6.Text = "Precio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(139, 68);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(140, 15);
            label7.TabIndex = 10;
            label7.Text = "Estado del producto";
            // 
            // cb_prods_estados
            // 
            cb_prods_estados.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cb_prods_estados.FormattingEnabled = true;
            cb_prods_estados.Location = new System.Drawing.Point(287, 55);
            cb_prods_estados.Name = "cb_prods_estados";
            cb_prods_estados.Size = new System.Drawing.Size(222, 23);
            cb_prods_estados.TabIndex = 2;
            cb_prods_estados.Text = "Seleccione estado";
            // 
            // b_print
            // 
            b_print.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            b_print.Location = new System.Drawing.Point(601, 369);
            b_print.Margin = new System.Windows.Forms.Padding(4);
            b_print.Name = "b_print";
            b_print.Size = new System.Drawing.Size(189, 42);
            b_print.TabIndex = 9;
            b_print.Text = "Guardar PDF 🖨️";
            b_print.UseVisualStyleBackColor = true;
            b_print.Click += new EventHandler(b_print_Click);

            KryptonManager mg = new KryptonManager();
            mg.GlobalPalette = p;
        }
        //BUSCAR
        private void b_prod_buscar_Click(object sender, EventArgs e)
        { r_prods.buscar(tabla_prods, t_prods_min, t_prods_max, cb_prods_estados, chk_habitaciones.Checked, chk_servicios.Checked, chk_alimentos.Checked, chk_bebidas.Checked); }

        //GUARDAR PDF
        private void b_print_Click(object sender, EventArgs e)
        { r_prods.save(t_prods_min.Text, t_prods_max.Text, cb_prods_estados.SelectedIndex.ToString(), chk_habitaciones.Checked, chk_servicios.Checked, chk_alimentos.Checked, chk_bebidas.Checked); }
        //REINICIAR
        private void b_prod_restart_Click(object sender, EventArgs e)
        { t_prods_max.Clear();t_prods_min.Clear();tabla_prods.Rows.Clear();t_prods_min.Focus();}
    }


    internal class reporte_prods
    {
        public static void cargar(ComboBox cb_estados)
        {
            Cursor.Current = Cursors.WaitCursor;
            dynamic estados_json = JsonConvert.DeserializeObject(_rest.consume("http://localhost/estado.json"));
            foreach (dynamic a in estados_json) cb_estados.Items.Add(a.First.estado);
            Cursor.Current = Cursors.Default;
        }

        public static void save(string p1, string p2, string p3, bool h, bool s, bool a, bool b)
        {
            SaveFileDialog save = new SaveFileDialog();//guiardar el archivo
            save.DefaultExt = "pdf";
            save.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss")); //especificicamos el tipo de archivo y nombre
            //CORREGIR ESTO
            String[] pars = get_params(p1, p2, p3, h, s, a, b);
            string url = ($"http://localhost/productos/web/{pars[0]}+{pars[1]}+{pars[2]}+{pars[3]}+{pars[4]}+{pars[5]}+{pars[6]}_{dinusuario.id}");
            if (save.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(url);
                var generar = new topdf(url, save.FileName);
            }
        }
        public static String[] get_params(string p1, string p2, string p3, bool h, bool s, bool a, bool b)
        {
            String[] pars = { "$", "$", "$", "$", "$", "$", "$" };
            //si se filtra por valor min
            if (p1 != "") pars[0] = p1;
            //si se filtra por valor max
            if (p2 != "") pars[1] = p2;
            //si se filtra por estado
            if (p3 != "-1") pars[2] = (mt.mathsu.toint(p3) + 1).ToString();

            //FILTROS CHECKBOX

            //si quiere habitaciones
            if (h) pars[3] = "1";
            //si quiere servicios
            if (s) pars[4] = "1";
            //si quiere alimentos
            if (a) pars[5] = "1";
            //si quiere bebidas en el report
            if (b) pars[6] = "1";
            return pars;
        }

        public static void buscar(DataGridView tabla, TextBox t_min, TextBox t_max, ComboBox cb_estados, bool habs, bool servs, bool alimentos, bool bebidas)
        {

            tabla.Rows.Clear();
            Cursor.Current = Cursors.WaitCursor;
            //String[] pars = get_params(t_min.Text, t_max.Text);
            //MessageBox.Show($"{pars[0]}, {pars[1]}, {pars[2]}");
            //string json = _rest.consume($"http://localhost/productos/{pars[0]}+{pars[1]}+{pars[2]}");
            //dynamic data = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(json);
            string min = "0", max = t_max.Text;
            if (t_min.Text != "") min = t_min.Text;
            bool add = false, maxear = false, filtro1 = false;
            if (max == "") maxear = true;
            /*
            foreach (var item in proyecto.formsu.lista_articulos.lista)
            {
                if (maxear) max = item.precio;
                filtro1 = comparar(item.precio, min, max); add = false;
                if (!habs && !servs && !alimentos & !bebidas) add = true;
                else
                {
                    if (habs) if (item.categoria == "Habitaciones") add = true;
                    if (servs) if (item.categoria == "Servicios") add = true;
                    if (alimentos) if (item.categoria == "Alimentos") add = true;
                    if (bebidas) if (item.categoria == "Bebidas") add = true;
                }
                if (add && filtro1) add_table(item.nombre, item.desc, item.precio, item.categoria, item.estado, tabla);
            }
            */
            Cursor.Current = Cursors.Default;
        }
        static bool comparar(string val, string min, string max)
        { return compare_max(max, val) && compare_min(min, val); }
        static bool compare_min(string min, string val)
        { if (int.Parse(min) <= int.Parse(val)) return true; return false; }
        static bool compare_max(string max, string val)
        { if (int.Parse(max) >= int.Parse(val)) return true; return false; }
        public static void add_table(string name, string desc, string precio, string cat, string estado, DataGridView t)
        {
            t.Rows.Add(name, desc, "$" + precio, cat, estado);
        }
    }

}
