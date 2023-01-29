using System;
using System.Windows;
using System.Windows.Controls;

namespace demo_transferDataBewteenTwoUserControl
{
    /// <summary>
    /// Publisher.xaml 的交互逻辑
    /// </summary>
    public partial class Publisher : UserControl
    {
        static public event EventHandler<CustomData> DataChanged;

        public Publisher()
        {
            InitializeComponent();
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            CustomData data = new CustomData();
            FrameworkElement element = e.Source as FrameworkElement;
            switch (element.Name)
            {
                case "btn1":
                    data.Message = "btn1";
                    break;
                case "btn2":
                    data.Message = "btn2";
                    break;
                case "btn3":
                    data.Message = "btn3";
                    break;
                default:
                    data.Message = "nothing";
                    break;
            }
            DataChanged?.Invoke(this, data);
        }
    }
}
