using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DropDownEnableDisable.Models
{
    public class StudentModel
    {
        [Display(Name = "Full Name:")]
        [Required(ErrorMessage = "Full Name is required.")]
        public string FullName { get; set; }

        [Display(Name = "Are you exempt from the fee?:")]
        [UIHint("YesNoDropDownList")]
        public string IsExempted { get; set; }

        [Display(Name = "Comment if Exempt:")]
        public string CommentIfExempt { get; set; }
    }
}