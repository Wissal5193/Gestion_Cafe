using Microsoft.AspNetCore.Mvc;
using projet.Data;
using projet.Models;
using System.Linq;

public class ProduitsController : Controller
{
    private readonly ApplicationDbContext _context;

    public ProduitsController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult ListeProduit()
    {
        var produits = _context.Produits.ToList(); // récupère les produits depuis la base
        return View(produits);
    }
}
