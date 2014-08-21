using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UploadFiles.Models
{
    public class NewJobViewModel
    {
        [Required]
        [DisplayName("Insert a Job Name")]
        public string JobName { get; set; }

        [DisplayName("Select Files")]
        public IEnumerable<HttpPostedFileBase> files { get; set; }

    }
}