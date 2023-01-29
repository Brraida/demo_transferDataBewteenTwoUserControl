using System.Windows.Controls;

namespace demo_transferDataBewteenTwoUserControl
{
    /// <summary>
    /// Subscriber1.xaml 的交互逻辑
    /// </summary>
    public partial class Subscriber1 : UserControl
    {
        public Subscriber1()
        {
            InitializeComponent();
            Publisher.DataChanged += EventHandler;
        }

        private void EventHandler(object sender, CustomData e)
        {
            textBox_showMessage.Text = e.Message;
        }
    }
}
