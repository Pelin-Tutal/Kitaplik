using Kitaplik.Models;
using Kitaplik.repository;
using Microsoft.AspNetCore.Mvc;

namespace Kitaplik.Controllers;

public class BookController : Controller
{
    // Dependency Injection

    private readonly repositorybaglantisi _repository;

    public BookController(repositorybaglantisi repository)
    {
      _repository = repository;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(book book)
    {
        _repository.Add(book);
        _repository.SaveChanges();

        return RedirectToAction("Index","Home");
    }



}
