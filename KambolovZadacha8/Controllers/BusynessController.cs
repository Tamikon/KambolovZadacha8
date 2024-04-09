using Microsoft.AspNetCore.Mvc;
using KambolovZadacha8.Models;

public class BusynessController : Controller
{
    public IActionResult Index()
    {
        // Здесь вы можете получить список предметов преподавателя и передать его на представление
        // Например:
        // var subjects = _repository.GetSubjectsByTeacherId(teacherId);
        // return View(subjects);
        return View();
    }

    public IActionResult Change()
    {
        // Здесь обработайте добавление/редактирование предмета
        // Если нужно передать модель предмета на представление, то сделайте это
        // Например:
        // return View(new Subject());
        return View();
    }

    [HttpPost]
    public IActionResult Save(Subject subject)
    {
         if (ModelState.IsValid)
        {
           return RedirectToAction("Index");
        }
        return View("Change", subject);
    }
}
