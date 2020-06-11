using LoLProf.Controller;
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
using System.Windows.Shapes;

namespace LoLProf.View
{
    /// <summary>
    /// Interaction logic for WindowTFT.xaml
    /// </summary>
    public partial class WindowTFT : Window
    {
        ControllerTFT controllerTFT;
        public WindowTFT()
        {
            controllerTFT = new ControllerTFT();
            InitializeComponent();
            this.DataContext = controllerTFT.GetContext();
        }
    }
}
