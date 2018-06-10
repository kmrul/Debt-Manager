﻿using DebtManager.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DebtManager.Core.Entities
{
    public class MyDebit: Entity
    {
        public int Id { get; set; }

        [Required]
        [ForeignKey("Id")]
        [Display(Name ="Contact Name")]
        public int debtId { get; set; }

        [Required]
        [Display(Name ="Amount")]
        public decimal Amount { get; set; }

        [Required]
        public string Currency { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreateAt { get; set; }

        [DataType(DataType.Date)]
        public DateTime UpdateAt { get; set; }

        public bool Status { get; set; }

        [Display(Name ="Commnet")]
        public string Comment { get; set; }
    }
}
