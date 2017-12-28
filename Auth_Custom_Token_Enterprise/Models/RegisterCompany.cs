﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Auth_Custom_Token_Enterprise.Models
{
    [Table("RegisterCompany")]
    public class RegisterCompany
    {
        [Key]
        public int CompanyID { get; set; }

        [Required(ErrorMessage = "Required Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Required PersonInCharge")]
        public string PersonInCharge { get; set; }
        public DateTime CreateOn { get; set; }

        [Required(ErrorMessage = "Required EmailID")]
        public string EmailID { get; set; }

        [Required(ErrorMessage = "Required Status")]
        public bool Status { get; set; }

        public int UserID { get; set; }
    }
}