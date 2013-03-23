using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;

namespace ContactWeb.Models
{
    public class Contact : IValidatableObject
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }


        public System.Collections.Generic.IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var list = new List<ValidationResult>();
            var contacts = new ContactBUS().GetContacts().Where(c => c.Email.ToLower() == this.Email.ToLower());
            if (this.Id > 0)
            {
                if (contacts.Any() && contacts.Single().Id != this.Id)
                    list.Add(new ValidationResult("Email exists"));
            }
            else
            {
                if(contacts.Any())
                    list.Add(new ValidationResult("Email exists"));
            }

            return list;

        }
    }
}