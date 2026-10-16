using GameVault.Web.Data;
using GameVault.Web.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameVault.Web.Pages;

public class IndexModel : PageModel
{
    private readonly GameRepository _repo;

    public IndexModel(GameRepository repo)
    {
        _repo = repo;
    }

    public List<Game> Games { get; private set; } = new();
    public string Query { get; private set; } = "";

    public void OnGet(string? q)
    {
        Query = q ?? "";
        Games = _repo.Search(Query);
    }
}