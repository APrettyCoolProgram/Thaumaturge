// 260712_code
// 260712_documentation

using System.Windows;
using Thaumaturge.ThaumDatabase;

namespace Thaumaturge;

/// <summary>Interaction logic for MainWindow.xaml</summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void RebuildDatabase()
    {
        Build.All();
    }

    /*
     * Event Handlers
     */

    private void btnRebuildThaumaturgeDatabase_Click(object sender, RoutedEventArgs e) => RebuildDatabase();
}