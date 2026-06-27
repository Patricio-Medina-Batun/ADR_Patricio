using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TallerApp.Application;
using TallerApp.Domain;
using TallerApp.Web.Models;

namespace TallerApp.Web.Controllers;

public class HomeController : Controller
{
    
    private readonly OrdenService _ordenService;

    
    public HomeController(OrdenService ordenService)
    {
        _ordenService = ordenService;
    }

    
    public IActionResult Index()
    {
        var ordenes = _ordenService.ObtenerHistorial();
        return View(ordenes);
    }

    
    [HttpPost]
    public IActionResult Crear(OrdenTrabajo orden)
    {
        _ordenService.RecibirVehiculo(orden);
        return RedirectToAction("Index");
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