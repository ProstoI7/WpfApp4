using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double brushSize = 5;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ColorBrush_(object sender, SelectionChangedEventArgs e)
        {
            if (ColorBrush.SelectedIndex == 0)
            {
                DrawingAttributes.Color = Colors.Black;
            }
            if (ColorBrush.SelectedIndex == 1)
            {
                DrawingAttributes.Color = Colors.Red;
            }
            if (ColorBrush.SelectedIndex == 2)
            {
                DrawingAttributes.Color = Colors.Green;
            }
            if (ColorBrush.SelectedIndex == 3)
            {
                DrawingAttributes.Color = Colors.Blue;
            }
            if (ColorBrush.SelectedIndex == 4)
            {
                DrawingAttributes.Color = Colors.Yellow;
            }
            if (ColorBrush.SelectedIndex == 5)
            {
                DrawingAttributes.Color = Colors.Orange;
            }
            if (ColorBrush.SelectedIndex == 6)
            {
                DrawingAttributes.Color = Colors.Purple;
            }
            if (ColorBrush.SelectedIndex == 7)
            {
                DrawingAttributes.Color = Colors.Pink;
            }
            if (ColorBrush.SelectedIndex == 8)
            {
                DrawingAttributes.Color = Colors.Gray;
            }
            if (ColorBrush.SelectedIndex == 9)
            {
                DrawingAttributes.Color = Colors.Brown;
            }
            if (ColorBrush.SelectedIndex == 10)
            {
                DrawingAttributes.Color = Colors.Turquoise;
            }
            if (ColorBrush.SelectedIndex == 11)
            {
                DrawingAttributes.Color = Colors.Lavender;
            }
        }

        private void BrushSize_(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            brushSize = e.NewValue;
            if (DrawingAttributes != null)
            {
                DrawingAttributes.Height = brushSize;
                DrawingAttributes.Width = brushSize;
            }
        }

        private void SetDrawingMode(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (Canvas != null)
            {
                if (DrawRadioButton.IsChecked == true)
                {
                    Canvas.EditingMode = InkCanvasEditingMode.Ink;
                }
                else if (EditRadioButton.IsChecked == true)
                {
                    Canvas.EditingMode = InkCanvasEditingMode.Select;
                }
                else if (EraseRadioButton.IsChecked == true)
                {
                    Canvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
                }
            }

        }
    }
}