public partial class Window1 : Window
{
    public Window1()
    {
        InitializeComponent();

    }

    private void auth_button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var context = new PostgresContext();
        if (context != null)
        {
            var user = context.Clients.FirstOrDefault(x => x.Login == login_box.Text && x.Password == password_box.Text);
            if (user != null)
            {
                MainWindow mainWindow = new MainWindow(user);
                mainWindow.Show();
                this.Close();
            }
        }
    }

    private void enter_button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        this.Close();
    }
