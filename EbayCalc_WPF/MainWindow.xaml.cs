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

using EbayCalc_Utils;

namespace EbayCalc_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MouseDown += (o, e) => {if (e.ChangedButton == MouseButton.Left) DragMove(); };
            PreviewKeyDown += (o, e) => {if (e.Key == Key.Escape) Close(); };
        }

        private void Calculate()
        {
            EbayCalcData_Model ebayDataModel = new EbayCalcData_Model();
            
            ebayDataModel.TransactionType = EbayCalcData_Model.TransactionTypeEnum.STORE;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click");
        }
    }
}
