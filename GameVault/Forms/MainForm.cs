using GameVault.Data;
using GameVault.Models;
using MySqlConnector;

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
        cmbPlatform.SelectedIndex = 0;
        cmbCondition.SelectedIndex = 0;
        LoadGames();
    }

    private void LoadGames()
    {
        try
        {
            dgvGames.DataSource = _repo.Search(txtSearch.Text);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Could not load games: " + ex.Message);
        }
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        LoadGames();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtTitle.Text))
        {
            MessageBox.Show("Title is required.");
            return;
        }

        if (numPrice.Value <= 0)
        {
            MessageBox.Show("Price must be greater than zero.");
            return;
        }

        var game = new Game
        {
            Title = txtTitle.Text.Trim(),
            Platform = cmbPlatform.Text,
            Genre = txtGenre.Text.Trim(),
            Condition = cmbCondition.Text,
            Price = numPrice.Value,
            Quantity = (int)numQuantity.Value,
            ReleaseYear = (int)numYear.Value
        };

        try
        {
            _repo.Add(game);
            LoadGames();
            ClearFields();
        }
        catch (MySqlException ex) when (ex.ErrorCode == MySqlErrorCode.DuplicateKeyEntry)
        {
            MessageBox.Show("This game already exists for that platform and condition.");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Could not add the game: " + ex.Message);
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        ClearFields();
    }

    private void ClearFields()
    {
        txtTitle.Clear();
        txtGenre.Clear();
        cmbPlatform.SelectedIndex = 0;
        cmbCondition.SelectedIndex = 0;
        numPrice.Value = 0;
        numQuantity.Value = 0;
        numYear.Value = 2024;
        txtTitle.Focus();
    }

    private void btnAdd_Click_1(object sender, EventArgs e)
    {

    }

    private void txtSearch_TextChanged_1(object sender, EventArgs e)
    {

    }
}