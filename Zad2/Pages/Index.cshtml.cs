using Zad2.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Zad2.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    
    [BindProperty]
    
    public FizzBuzzForm FizzBuzz { set; get; }
    
    [BindProperty(SupportsGet = true)]

    public string Name { set; get; }
    
    public string Response { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public IActionResult OnPost()
    {
        int? number = FizzBuzz.Number;
        
        // if (!ModelState.IsValid)
        // {
        //     Response = "Podana wartość jest nieprawidłowa.";
        //     return Page();
        // }
        
        if (number % 3 == 0 && number % 5 == 0)
        {
            Response = "FizzBuzz";
            return Page();
        }
        
        else if (number % 3 == 0)
        {
            Response = "Fizz";
            return Page();
        }
        else if (number % 5 == 0)
        {
            Response = "Buzz";
            return Page();
        }
        else
        {
            Response = $"Liczba {number} nie spełnia kryteriów FizzBuzz";
            return Page();
        }

        return Page();
    }
    
    public void OnGet()
    {
        if (string.IsNullOrWhiteSpace(Name))
        {
            Name = "User";
        }
    }
    
}