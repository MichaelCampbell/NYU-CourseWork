using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ContactWeb.Models
{
    public class Contact : IValidatableObject
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "First Name:")]
        public string FirstName { get; set; }
        
        [Required]
        [Display(Name = "Last Name:")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email Address:")]
        public string Email { get; set; }

        public System.Collections.Generic.IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //throw new NotImplementedException();
            var list = new List<ValidationResult>();
            var contacts = new ContactBUS().GetContacts().Where(c => c.Email.ToLower() == this.Email.ToLower());
            if (contacts.Any() && contacts.Single().Id != this.Id)
            {
                list.Add(new ValidationResult("Email Address already exists"));
            }
            else
            {
                if(contacts.Any())
                    list.Add(new ValidationResult("Email Address already exists"));
            }
            
            return list;
        }
    }
}