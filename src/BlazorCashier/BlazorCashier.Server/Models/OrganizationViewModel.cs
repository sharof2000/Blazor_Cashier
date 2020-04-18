﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCashier.Server.Models
{
    public class OrganizationViewModel
    {
        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [Required]
        [StringLength(50)]
        public string OwnerName { get; set; }

        [StringLength(256)]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string CurrencyId { get; set; }

        [Required]
        [StringLength(50)]
        public string CountryId { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Telephone { get; set; }

        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Website { get; set; }

        [Required]
        [StringLength(50)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [StringLength(50)]
        public string FinancialNumber { get; set; }

        public IEnumerable<CountryDetail> Countries { get; set; }
        public IEnumerable<CurrencyDetail> Currencies { get; set; }
        
    }

    public class CountryDetail
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class CurrencyDetail
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
