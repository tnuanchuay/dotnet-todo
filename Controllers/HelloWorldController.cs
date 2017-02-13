using Microsoft.AspNetCore.Mvc;

namespace todo_raw.Controllers{

    public class HelloWorldController : Controller{
	[Route("/")]
	[HttpGet]
	public string HelloWorld(){
		return "Hello World";
	}        
    }
}
