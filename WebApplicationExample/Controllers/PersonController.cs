using Microsoft.AspNetCore.Mvc;

namespace WebApplicationExample.Controllers;
[ApiController]
[Route("[controller]")]
public class PersonController : Controller
{
    [HttpGet]
    public IEnumerable<Person> Get()
    {
        return new Person[] { new Person("Demo Person", "+375(33)725-12-53"), new Person("Ivan", "+7(383)891-25-47"), new Person("Petya")};
    }
}