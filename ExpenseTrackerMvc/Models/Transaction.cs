﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerMvc.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public string? Note { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
