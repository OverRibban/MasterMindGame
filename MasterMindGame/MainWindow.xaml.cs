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

namespace MasterMindGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string CurrentColor;
        static Button ChosenBoardButton = new Button();
        static int CurrentRow = 4;
        static bool[] PickedRowButtons = new bool[4];
        static Button[][] jagged_arr = new Button[5][];
        public MainWindow()
        {
            InitializeComponent();

            jagged_arr[0] = new Button[] {P2Row1Col1Btn, P2Row1Col2Btn, P2Row1Col3Btn, P2Row1Col4Btn};
            jagged_arr[1] = new Button[] { P2Row2Col1Btn, P2Row2Col2Btn, P2Row2Col3Btn, P2Row2Col4Btn };
            jagged_arr[2] = new Button[] { P2Row3Col1Btn, P2Row3Col2Btn, P2Row3Col3Btn, P2Row3Col4Btn };
            jagged_arr[3] = new Button[] { P2Row4Col1Btn, P2Row4Col2Btn, P2Row4Col3Btn, P2Row4Col4Btn };
            jagged_arr[4] = new Button[] { P2Row5Col1Btn, P2Row5Col2Btn, P2Row5Col3Btn, P2Row5Col4Btn };
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    jagged_arr[i][j].Tag = i.ToString();
                }
            }
        }

private void P2Row4Col4Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Player1Button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void P2Row1Col1Btn_Click(object sender, RoutedEventArgs e)
        {
            jagged_arr[3][0].Content = "Keep watching";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button ColorButton = (sender as Button);
            CurrentColor = ColorButton.Background.ToString();
        }

        private void P2Row5Col1Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Player2BoardButton(object sender, RoutedEventArgs e)
        {
            ChosenBoardButton = (sender as Button);
            ChosenBoardButton.IsEnabled = false;
            ChosenBoardButton.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom(CurrentColor));
            if(P2Row5Col1Btn.IsEnabled == false && P2Row5Col2Btn.IsEnabled == false && P2Row5Col3Btn.IsEnabled == false && P2Row5Col4Btn.IsEnabled == false)
            {
                P2Row5Col1Btn.Content = "hello";
            }

        }
    }
}
