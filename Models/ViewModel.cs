using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shippingrequest.Models
{
    public class ViewModel
    {
        public List<string> deptList { get; set; }
        public List<string> countryList { get; set; }

    }
}