using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PTRex.Models
{
    [MetadataType(typeof(UserProfileBuddy))]
    public partial class UserProfile
    {
    }

    sealed class UserProfileBuddy
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Date of Birth")]
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Email { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Photo")]
        public string Photo { get; set; }
    }
}
