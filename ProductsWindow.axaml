public partial class MainWindow : Window
{
    public List<Product> _product;

    public MainWindow(Client client)
    {
        InitializeComponent();
        var context = new PostgresContext();
        var product = context.Products.ToList();
        _product = product.ToList();
        DataContext = new { Products = _product };
    }
    public MainWindow()
    {
        InitializeComponent();
        var context = new PostgresContext();
        var product = context.Products.ToList();
        _product = product.ToList();
        DataContext = new {Products =  _product};
        price_box.IsVisible = false;
        type_box.IsVisible = false;
        name_box.IsVisible = false;
        search_box.IsVisible = false;
    }

    private void search_box_KeyUp(object? sender, Avalonia.Input.KeyEventArgs e)
    {

    }

    private void escape_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Window1 authWindow = new Window1();
        authWindow.Show();
        this.Close();
    }
}
