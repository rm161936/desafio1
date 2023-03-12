using Desafío1App.Models;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desafío1App.Views
{
    public partial class MainForm : Form
    {
        private List<CategoriaModel> categorias = CategoriaModel.LocalDbCategories();
        public MainForm()
        {
            InitializeComponent();
            //INICIALIZA EL DATAGRIDVIEW AL MOMENTO DE CARGA EL FORMULARIO
            InitializeCategories();
            //CUSTOMIZACIONES INICIALES DEL FORMULARIO
            CustomForm();

        }

        private void CustomForm()
        {

            //CARGAR CB CON CATEGORIAS
            categorias.ForEach(i =>
            {
                comboBox1.Items.Add(i.Categoria);
            });
            WindowState = FormWindowState.Maximized;
            PictureBoxMax.Visible = false;
            TabLibros.BackColor = Color.FromArgb(95, 120, 128);
            TabEstadisticas.BackColor = Color.FromArgb(95, 120, 128);
            TabProgramas.BackColor = Color.FromArgb(95, 120, 128);
            TabProgramacion.BackColor = Color.FromArgb(95, 120, 128);
            LblCategory.Text = "Programas de entretenimiento";
            LblCategory.Font = new Font("Century Gothic", 30, FontStyle.Bold);
            LblCategory.ForeColor = Color.White;
            label5.Text = "Libros";
            label5.Font = new Font("Century Gothic", 30, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label6.Text = "Lenguajes de programación";
            label6.Font = new Font("Century Gothic", 30, FontStyle.Bold);
            label6.ForeColor = Color.White;
        }

        private void PictureBoxClose_MouseEnter(object sender, EventArgs e)
        {
            PictureBoxClose.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxClose.Cursor = Cursors.Hand;
        }

        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de cerrar la aplicación?", "Cierre de sesión", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }

        private void PictureBoxClose_MouseLeave(object sender, EventArgs e)
        {
            PictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxClose.Cursor = Cursors.Default;
        }

        private void PictureBoxMax_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            PictureBoxRestore.Visible = true;
            PictureBoxMax.Visible = false;
        }

        private void PictureBoxMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PictureBoxRestore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            PictureBoxRestore.Visible = false;
            PictureBoxMax.Visible = true;
        }

        [DllImport("user32.DLL", EntryPoint ="ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
           ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void panel1_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void PictureBoxRestore_MouseEnter(object sender, EventArgs e)
        {
            PictureBoxRestore.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxRestore.Cursor = Cursors.Hand;
        }

        private void PictureBoxRestore_MouseLeave(object sender, EventArgs e)
        {
            PictureBoxRestore.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxRestore.Cursor = Cursors.Default;
        }

        private void PictureBoxMin_MouseEnter(object sender, EventArgs e)
        {
            PictureBoxMin.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxMin.Cursor = Cursors.Hand;
        }

        private void PictureBoxMin_MouseLeave(object sender, EventArgs e)
        {
            PictureBoxMin.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxMin.Cursor = Cursors.Default;
        }

        private void PictureBoxMax_MouseEnter(object sender, EventArgs e)
        {
            PictureBoxMax.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxMax.Cursor = Cursors.Hand;
        }

        private void PictureBoxMax_MouseLeave(object sender, EventArgs e)
        {
            PictureBoxMax.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxMax.Cursor = Cursors.Default;
        }

        private void InitializeCategories()
        {

            var entertainment = categorias.FirstOrDefault(e => e.Categoria.Contains("entretenimiento"));
            var books = categorias.FirstOrDefault(e => e.Categoria.Contains("Libros"));
            var languages = categorias.FirstOrDefault(e => e.Categoria.Contains("Lenguajes"));
            List<DatosModel> entretenimiento = new();
            List<DatosLibrosModel> libros = new();
            List<DatosProgramacionModel> programacion = new();

            entertainment?.RecursoModelList.ForEach(e =>
            {
                if (e.DatosPrograma != null)
                {
                    entretenimiento.Add(e.DatosPrograma);
                }
            });
            books?.RecursoModelList.ForEach(e =>
            {
                if (e.DatosLibros != null)
                {
                    libros.Add(e.DatosLibros);
                }
            });
            languages?.RecursoModelList.ForEach(e =>
            {
                if (e.DatosProgramacion != null)
                {
                    programacion.Add(e.DatosProgramacion);
                }
            });

            //ORIGEN DE DATOS DE DATA GRIDVIEW
            var sourceEnterteinment = new BindingSource
            {
                DataSource = entretenimiento
            };
            var sourceBooks = new BindingSource
            {
                DataSource = libros
            };
            var sourceLanguages = new BindingSource
            {
                DataSource = programacion
            };

            //CUSTOMIZACIÓN DE DATAGRIDVIEWS
            dataGridView4.DataSource = sourceBooks;
            dataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView4.Columns[0].Visible = false;
            dataGridView4.Columns[9].Visible = false;

            dataGridView4.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView4.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView4.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView4.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView4.Columns[6].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView4.Columns[7].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView4.Columns[8].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGridView4.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView4.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView4.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView4.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView4.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView4.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView4.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView6.DataSource = sourceLanguages;
            dataGridView6.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView6.Columns[0].Visible = false;
            dataGridView6.Columns[9].Visible = false;

            dataGridView6.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView6.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView6.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView6.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView6.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView6.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView6.Columns[6].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGridView6.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView6.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView6.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView6.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView6.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView6.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView6.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView6.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DGVCategoria.DataSource = sourceEnterteinment;
            DGVCategoria.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGVCategoria.Columns[0].Visible = false;
            DGVCategoria.Columns[8].Visible = false;

            DGVCategoria.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGVCategoria.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGVCategoria.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGVCategoria.Columns[7].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            DGVCategoria.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGVCategoria.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGVCategoria.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGVCategoria.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGVCategoria.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGVCategoria.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGVCategoria.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            DGVCategoria.Width = Convert.ToInt32(this.Width * 0.9);
            DGVCategoria.Height = Convert.ToInt32(this.Height * 0.9);
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DgvCharts.Rows.Clear();
            DgvCharts.Refresh();
            if (!string.IsNullOrEmpty(comboBox1.SelectedItem.ToString()))
            {
                DgvCharts.ColumnCount = 2;
                DgvCharts.Columns[0].Name = "Nombre";
                DgvCharts.Columns[1].Name = "Porcentaje";
                DgvCharts.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DgvCharts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                if (comboBox1.SelectedItem.ToString().Contains("entretenimiento"))
                {
                    var categoria = categorias.Where(e => e.Categoria.Contains("entretenimiento")).FirstOrDefault();
                    categoria.RecursoModelList.Where(e => e.CategoriaId.Equals(categoria.Id)).ToList().ForEach(e =>
                    {
                        DataGridViewRow row = (DataGridViewRow)DgvCharts.Rows[0].Clone();
                        row.Cells[0].Value = e.Nombre;
                        row.Cells[1].Value = e.Percentage;
                        DgvCharts.Rows.Add(row);
                    });

                }else if (comboBox1.SelectedItem.ToString().Contains("Libros"))
                {
                    var categoria = categorias.Where(e => e.Categoria.Contains("Libros")).FirstOrDefault();
                    categoria.RecursoModelList.Where(e => e.CategoriaId.Equals(categoria.Id)).ToList().ForEach(e =>
                    {
                        DataGridViewRow row = (DataGridViewRow)DgvCharts.Rows[0].Clone();
                        row.Cells[0].Value = e.Nombre;
                        row.Cells[1].Value = e.Percentage;
                        DgvCharts.Rows.Add(row);
                    });
                }
                else if (comboBox1.SelectedItem.ToString().Contains("Lenguaje"))
                {
                    var categoria = categorias.Where(e => e.Categoria.Contains("Lenguaje")).FirstOrDefault();
                    categoria.RecursoModelList.Where(e => e.CategoriaId.Equals(categoria.Id)).ToList().ForEach(e =>
                    {
                        DataGridViewRow row = (DataGridViewRow)DgvCharts.Rows[0].Clone();
                        row.Cells[0].Value = e.Nombre;
                        row.Cells[1].Value = e.Percentage;
                        DgvCharts.Rows.Add(row);
                    });
                }
            }
        }

        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);
        private void btnGenChart_Click(object sender, EventArgs e)
        {
            SeriesCollection series = new();
            foreach (DataGridViewRow row in DgvCharts.Rows)
            {
                try
                {
                    series.Add(new PieSeries() { Title = row.Cells[0].Value.ToString(), Values = new ChartValues<int> { Int32.Parse(row.Cells[1].Value.ToString()) }, DataLabels = true, LabelPoint = labelPoint });
                }
                catch (Exception) { }

            }
            pieChart1.Series = series;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }
    }
}
