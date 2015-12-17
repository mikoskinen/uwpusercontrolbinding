using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace uwpdatatemplatebinding
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
        }

        private ObservableCollection<MyUserControlVm> coll;
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            coll = new ObservableCollection<MyUserControlVm>();
            coll.Add(new MyUserControlVm("http://libcloud.readthedocs.org/en/latest/_images/azure.jpg"));
            coll.Add(new MyUserControlVm("http://www.nimbo.com/wp-content/uploads/windows-azure-logo-nimbo1.png"));

            this.Flip.ItemsSource = coll;

            base.OnNavigatedTo(e);
        }
    }


}
