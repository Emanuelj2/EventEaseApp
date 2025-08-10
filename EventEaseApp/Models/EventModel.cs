using System;
using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models
{
    public class EventModel
    {
 
        public int Id { get; set; }  // Primary key required by EF Core

        [Required(ErrorMessage = "Event name is required")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; } = string.Empty;

        [Required(ErrorMessage = "Time is required")]
        public string Time { get; set; } = string.Empty;
    }
}