using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
namespace Не_удалять_пж
{
    public partial class MainWindow : Window
    {
        user_05Entities connect = new user_05Entities();
        public MainWindow()
        {
            InitializeComponent();
            AddMaterials();
        }
        void AddMaterials()
        {
            
            Border border = new Border();
            border.Width = 700;
            border.Height = 100;
            border.Margin = new Thickness(5);
            border.BorderThickness = new Thickness(1);
            border.BorderBrush = Brushes.Black;

            StackPanel stackColum = new StackPanel();
            stackColum.Orientation = Orientation.Horizontal;
            stackColum.Margin = new Thickness(10);

       
            Image image = new Image();
            image.Width = 100;
            image.Height = 500;
            image.Source = BitmapFrame.Create(new Uri("picture.png", UriKind.Relative));

            StackPanel stackText = new StackPanel();
            stackText.Margin = new Thickness(0);

            TextBlock TypeName= new TextBlock();
            TypeName.Margin = new Thickness(10, 0, 0, 0);
            TypeName.Text = "Тип материала | Наименование материала";
            TextSettings(TypeName);

            TextBlock size = new TextBlock();
            size.Margin = new Thickness(130,0,0,0);
            size.Text = "Остаток :";
            TextSettings(size);

            TextBlock Min = new TextBlock();
            Min.Margin = new Thickness(10,5,0,0);
            Min.Text = "Минимальное количество: 3шт";
            TextSettings(Min);

            TextBlock Diler = new TextBlock();
            Diler.Margin = new Thickness(0,0,0,0);
            Diler.Text = "Поставщики: Рога и копыта";
            TextSettings(Diler);

            Diler.Padding = new Thickness(10, 5, 0, 0);





            stackText.Children.Add(TypeName);
            stackText.Children.Add(Min);
            stackText.Children.Add(Diler);

            stackColum.Children.Add(image);
            stackColum.Children.Add(stackText);
            stackColum.Children.Add(size);
            border.Child = stackColum;
            ListMaterials.Children.Add(border);
        }
        void TextSettings(TextBlock block)
        {
            block.FontSize = 15;
            block.FontFamily = new FontFamily("Trebuchet MS");

        }
    }
}
