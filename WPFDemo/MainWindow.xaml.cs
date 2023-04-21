using System.Collections.Generic;
using System.Windows;


namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        //Criando Lista de tratamentos
        public List<Tratamento> tipotratamento = new List<Tratamento>();
        public List<OAR> oars = new List<OAR>();
        public List<Constraints> constraints = new List<Constraints>();
        public MainWindow()
        {
            InitializeComponent(); //Inicializando a seleção de tratamentos 

            tipotratamento.Add(new Tratamento { NomeTratamento = "Mama sem fossa UK START B 15fr x 266,7cGy (4000cGy)"});   // [0]

            tipotratamento.Add(new Tratamento { NomeTratamento = "Mama com fossa UK START B 15fr x 266,7cGy (4000cGy)" });  // [1]

            tipotratamento.Add(new Tratamento { NomeTratamento = "Mama FAST FORWARD LYMPHATIC RT 5fr x 520cGy (2600cGy)" });// [2]



            tipotratamento.Add(new Tratamento { NomeTratamento = "Mama FAST FORWARD 5fr x 520cGy (2600cGy)" });             // [3] 

                oars.Add(new OAR { NomeOar = "Coracao" });     // [0]

                    constraints.Add(new Constraints { NomeC = "V150cGy", ValorC = 30, ValorAceitavelC = 30 });
                    constraints.Add(new Constraints { NomeC = "V700cGy", ValorC = 5, ValorAceitavelC = 5 });

                oars.Add(new OAR { NomeOar = "Pulmao_esq" });  // [1]
                    constraints.Add(new Constraints { NomeC = "800", ValorC = 25, ValorAceitavelC = 25 });

                oars.Add(new OAR { NomeOar = "Pulmao_dir" });  // [2]
                oars.Add(new OAR { NomeOar = "Mama contra" }); // [3]

            ComboTratamento.ItemsSource = tipotratamento; //enviando os tipos de tratamentos para a seletor ComboBox
                        
            oars.Add(new OAR { NomeOar = "Coracao" });     // [0]
            oars.Add(new OAR { NomeOar = "Pulmao_esq" });  // [1]
            oars.Add(new OAR { NomeOar = "Pulmao_dir" });  // [2]
            oars.Add(new OAR { NomeOar = "Mama contra" }); // [3]

            
          
            

        }

        private void VerificaDVH_Click(object sender, RoutedEventArgs e)//Configurando botão para verificar DVH
        {
            MessageBox.Show($"Hello {tipotratamento[ComboTratamento.SelectedIndex].NomeTratamento}"); //Atual: Mostra o nome do tratamento selecionado. Futuro: Substituir por comparações no futuro
            if (tipotratamento[ComboTratamento.SelectedIndex].NomeTratamento.ToString() == "Mama sem fossa UK START B 15fr x 266,7cGy (4000cGy)")
            {
                MessageBox.Show("Voce selecionou correto!");

            }
            else
                MessageBox.Show("Voce selecionou errado!");
        }
    }

    public class Tratamento //Classe Tratamento (define o nome contido na ficha de tratamento)
    {
        public string NomeTratamento { get;set; } = string.Empty;
        
    }
    public class OAR : Tratamento //Classe de orgão de risco -> Cada tratamento possui uma lista de OARs
    {
        public string NomeOar { get; set; } = string.Empty;

    }

    public class Constraints : OAR //Classe de constraints para cada orgão de risco
    {
        public string NomeC { get; set; } = string.Empty;
        public int ValorC { get; set; } = 0;
        public int ValorAceitavelC { get; set; } = 0;
    }

}

