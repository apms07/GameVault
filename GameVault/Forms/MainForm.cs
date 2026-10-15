using GameVault.Data;

namespace GameVault;

public partial class MainForm : Form
{
    private readonly GameRepository _repo =
        new("Server=localhost;Database=gamevault_db;User=root;Password=#Ikariamm2007;");

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        try
        {
            dgvGames.DataSource = _repo.Search();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Could not load games: " + ex.Message);
        }
    }
}