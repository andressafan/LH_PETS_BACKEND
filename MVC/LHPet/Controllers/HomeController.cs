using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LhPet.Models;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
// Criando clientes
        Cliente cliente1 = new(01, "Arthur", "890.234.678-01", "arthur@gmail.com", "dog");
        Cliente cliente2 = new(02, "Almir", "123.456.789-00", "almir@yahoo.com", "cat");
        Cliente cliente3 = new(03, "John", "321.654.987-00", "john@hotmail.com", "bird");

        List<Cliente> listaClientes = [cliente1, cliente2, cliente3];


        ViewBag.listaClientes = listaClientes;


        // Criando fornecedores
        Fornecedor fornecedor1 = new(01, "Pets Forever", "14.234.123/12345-09", "contato@petsforever.com");
        Fornecedor fornecedor2 = new(02, "Mundo Animal", "11.111.111/1111-11", "info@mundoanimal.com");
        Fornecedor fornecedor3 = new(03, "Escola de Cachorro", "22.222.222/2222-22", "escola@cachorro.com");
        

        List<Fornecedor> listaFornecedores = [fornecedor1, fornecedor2, fornecedor3];
        
        ViewBag.listaFornecedores = listaFornecedores;
        return View();
        
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
