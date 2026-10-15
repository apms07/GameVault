using GameVault.Data;
using GameVault.Models;
using MySqlConnector;

namespace GameVault;

public partial class MainForm : Form
{
    private readonly GameRepository _repo = new(Database.ConnectionString);
    private int _selectedId = 0;

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

    // Clicar numa linha da tabela preenche os campos
    private void dgvGames_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        if (dgvGames.Rows[e.RowIndex].DataBoundItem is Game g)
        {
            _selectedId = g.Id;
            txtTitle.Text = g.Title;
            cmbPlatform.Text = g.Platform;
            txtGenre.Text = g.Genre;
            cmbCondition.Text = g.Condition;
            numPrice.Value = g.Price;
            numQuantity.Value = g.Quantity;
            numYear.Value = g.ReleaseYear ?? 2024;
        }
    }

    private Game? ReadGameFromFields()
    {
        if (string.IsNullOrWhiteSpace(txtTitle.Text))
        {
            MessageBox.Show("Title is required.");
            return null;
        }

        if (numPrice.Value <= 0)
        {
            MessageBox.Show("Price must be greater than zero.");
            return null;
        }

        return new Game
        {
            Id = _selectedId,
            Title = txtTitle.Text.Trim(),
            Platform = cmbPlatform.Text,
            Genre = txtGenre.Text.Trim(),
            Condition = cmbCondition.Text,
            Price = numPrice.Value,
            Quantity = (int)numQuantity.Value,
            ReleaseYear = (int)numYear.Value
        };
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        var game = ReadGameFromFields();
        if (game == null) return;

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

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (_selectedId == 0)
        {
            MessageBox.Show("Select a game from the table first.");
            return;
        }

        var game = ReadGameFromFields();
        if (game == null) return;

        try
        {
            _repo.Update(game);
            LoadGames();
            ClearFields();
        }
        catch (MySqlException ex) when (ex.ErrorCode == MySqlErrorCode.DuplicateKeyEntry)
        {
            MessageBox.Show("Another game with that title, platform and condition already exists.");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Could not update the game: " + ex.Message);
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (_selectedId == 0)
        {
            MessageBox.Show("Select a game from the table first.");
            return;
        }

        var answer = MessageBox.Show(
            "Are you sure you want to delete this game?",
            "Confirm delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (answer != DialogResult.Yes) return;

        try
        {
            _repo.Delete(_selectedId);
            LoadGames();
            ClearFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Could not delete the game: " + ex.Message);
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        ClearFields();
    }

    private void ClearFields()
    {
        _selectedId = 0;
        txtTitle.Clear();
        txtGenre.Clear();
        cmbPlatform.SelectedIndex = 0;
        cmbCondition.SelectedIndex = 0;
        numPrice.Value = 0;
        numQuantity.Value = 0;
        numYear.Value = 2024;
        txtTitle.Focus();
    }
}