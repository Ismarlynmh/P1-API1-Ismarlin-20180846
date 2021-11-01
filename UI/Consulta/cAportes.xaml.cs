using System;
using P1_API1_Ismarlin_20180846.BLL;
using P1_API1_Ismarlin_20180846.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace P1_API1_Ismarlin_20180846.UI
{
    /// <summary>
    /// Lógica de interacción para cAportes.xaml
    /// </summary>
    public partial class cAportes : Window
    {
        public cAportes()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Aportes>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //Persona
                        listado = AportesBLL.GetList(a => a.Persona.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;

                    case 1: //Concepto                       
                        listado = AportesBLL.GetList(a => a.Concepto.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;
                }
            }
            else
            {
                listado = AportesBLL.GetList(c => true);
            }

            if (DesdeDataPicker.SelectedDate != null)
                listado = listado.Where(c => c.Fecha.Date >= DesdeDataPicker.SelectedDate).ToList();

            if (HastaDatePicker.SelectedDate != null)
                listado = listado.Where(c => c.Fecha.Date <= HastaDatePicker.SelectedDate).ToList();

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;

            MontoTextBox.Text = listado.Sum(x => x.Monto).ToString("N2");
            ConteoTextBox.Text = listado.Count().ToString();
        }
    }
}
