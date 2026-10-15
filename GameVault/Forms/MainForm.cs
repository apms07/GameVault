using GameVault.Data;

namespace GameVault;

public partial class MainForm : Form
{
    private readonly GameRepository _repo = new(Database.ConnectionString);

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