using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PTRex.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web;

    [MetadataType(typeof(ProfilePixBuddy))]
    public partial class ProfilePix
    {

    }

    sealed class ProfilePixBuddy
    {
        public int ImageID { get; set; }
        [Display(Name = "Upload File")]
        public string ImagePath { get; set; }
        public int UserProfileID { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }
    }
}