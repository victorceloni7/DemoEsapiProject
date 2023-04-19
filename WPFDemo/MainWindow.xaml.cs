using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public List<Tratamento> tipotratamento = new List<Tratamento>(); //Criando 
        public MainWindow()
        {
            InitializeComponent();
            tipotratamento.Add(new Tratamento { Regiao = "Mama sem fossa", Tipo = "UK START B", FracDose = "15fr x 266,7cGy (4000cGy)" });
            tipotratamento.Add(new Tratamento { Regiao = "Mama com fossa", Tipo = "UK START B", FracDose = "15fr x 266,7cGy (4000cGy)" });
            tipotratamento.Add(new Tratamento { Regiao = "Mama", Tipo = "FAST FORWARD LYMPHATIC RT", FracDose = "5fr x 520cGy (2600cGy)" });
            tipotratamento.Add(new Tratamento { Regiao = "Mama", Tipo = "FAST FORWARD", FracDose = "5fr x 520cGy (2600cGy)" });

            ComboTratamento.ItemsSource = tipotratamento;
        }

        private void VerificaDVH_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {tipotratamento[0].Tipo}");
        }
    }

    public class Tratamento
    {
        public string Regiao { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public string FracDose { get; set; } = string.Empty;
        public string NomeTratamento
        {
            get
            {
                return $"{Regiao} {Tipo} {FracDose}";
            }
        }
    }
    public class OAR
    {
        public string NomeOar { get; set; } = string.Empty;
        public string Constraint { get; set; } = string.Empty;
        public string NomeTratamento { get; set; } = string.Empty;
    }
}

