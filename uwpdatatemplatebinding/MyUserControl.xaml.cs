using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace uwpdatatemplatebinding
{
    public sealed partial class MyUserControl : UserControl
    {
        public static readonly DependencyProperty FigurinePathProperty = DependencyProperty.Register(
            "FigurinePath", typeof (Uri), typeof (MyUserControl), new PropertyMetadata(default(Uri)));

        public Uri FigurinePath
        {
            get { return (Uri) GetValue(FigurinePathProperty); }
            set { SetValue(FigurinePathProperty, value); }
        }

        public MyUserControl()
        {
            this.InitializeComponent();
            (this.Content as FrameworkElement).DataContext = this;
        }
    }
    public class MyUserControlVm
    {
        public Uri Path { get; set; }

        public MyUserControlVm(string url)
        {
            Path = new Uri(url);
        }

        public void VmAction()
        {
            
        }
    }

}
