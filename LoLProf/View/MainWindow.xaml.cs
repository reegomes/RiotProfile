using LoLProf.Controller;
using LoLProf.View;
using LoLProf.View.ViewModel;
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

namespace LoLProf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ControllerMain controller;
        ViewModelMain viewModel;

        public MainWindow()
        {
            controller = new ControllerMain();
            viewModel = new ViewModelMain();
            InitializeComponent();


            this.DataContext = viewModel;
        }

        private void ButtonSignUp_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(viewModel.Region))
                return;
            if (string.IsNullOrEmpty(viewModel.SummonerName))
                return;
            if (string.IsNullOrEmpty(viewModel.GameMode))
                return;

            if(controller.GetSummoner(viewModel.SummonerName))
            {
                WindowProfile profile = new WindowProfile();
                WindowTFT windowTFT = new WindowTFT();

                switch (viewModel.GameMode.ToString())
                {
                    case "League Of Legends":
                        profile.Show();
                        this.Close();
                        break;
                    case "TeamFight Tatics":
                        windowTFT.Show();
                        this.Close();
                        break;
                    case "Legends of Runeterra":
                        MessageBox.Show("Soon");
                        break;
                    case "Valorant":
                        MessageBox.Show("Soon");
                        break;
                    case "LoL: Wild Rift":
                        MessageBox.Show("Soon");
                        break;
                    case "Project L":
                        MessageBox.Show("Soon");
                        break;
                    case "Project F":
                        MessageBox.Show("Soon");
                        break;
                    default:
                        //MessageBox.Show("Follow me on Twitter @ree_gms");
                        profile.Show();
                        this.Close();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Not Found");
            }

        }
    }
}
