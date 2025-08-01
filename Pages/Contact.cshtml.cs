using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace YassineAlsmayli.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public ContactForm ContactForm { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // TODO: Add email sending logic here
            // You can use SendGrid, MailKit, or other email services

            TempData["MessageSent"] = true;
            return RedirectToPage("Contact");
        }
    }

    public class ContactForm
    {
        [Required]
        public string Name { get; set; } = "";

        [Required, EmailAddress]
        public string Email { get; set; } = "";

        [Required]
        public string Message { get; set; } = "";
    }
}