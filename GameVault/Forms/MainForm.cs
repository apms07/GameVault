using GameVault.Data;
using GameVault.Models;
using MySqlConnector;

namespace GameVault;

public partial class MainForm : Form
{
    private const int LowStockLimit = 3;

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
            var games = _repo.Search(txtSearch.Text);
            dgvGames.DataSource = games;

            decimal total = games.Sum(g => g.Price * g.Quantity);
            int lowStock = games.Count(g => g.Quantity < LowStockLimit);
            lblTotal.Text = $"Total inventory value: {total:C2}   |   Low stock titles: {lowStock}";
        }
        catch (Exception ex)
        {
            MessageBox.Show("Could not load games: " + ex.Message);
        }
    }

    // Runs every time the grid finishes loading data: formats columns and colors rows
    private void dgvGames_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
    {
        if (dgvGames.Columns["Id"] != null)
            dgvGames.Columns["Id"].Visible = false;

        if (dgvGames.Columns["Price"] != null)
            dgvGames.Columns["Price"].DefaultCellStyle.Format = "C2";

        dgvGames.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        foreach (DataGridViewRow row in dgvGames.Rows)
        {
            if (row.DataBoundItem is Game g && g.Quantity < LowStockLimit)
            {
                row.DefaultCellStyle.BackColor = Color.MistyRose;
                row.DefaultCellStyle.ForeColor = Color.DarkRed;
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
        }
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        LoadGames();
    }

    // Clicking a row fills the fields
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

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label8_Click(object sender, EventArgs e)
    {

    }

    private void btnAdd_Click_1(object sender, EventArgs e)
    {

    }
}