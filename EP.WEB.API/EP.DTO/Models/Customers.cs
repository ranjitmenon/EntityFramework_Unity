﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.DTO.Models
{
    public class Customers
    {
     public int CustomerID { get; set; }
     public string CompanyName { get; set; }
     public string ContactName { get; set; }
	 public string ContactTitle { get; set; }
	 public string Address { get; set; }
     public string City { get; set; }
	 public string  Region { get; set; }
     public string PostalCode { get; set; }
     public string Country { get; set; }
     public int Phone { get; set; }
     public int Fax { get; set; }
    }
}
