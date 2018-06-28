using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Treehouse.FitnessFrog.Shared.Models;

namespace Treehouse.FitnessFrog.Spa.Dto
{
    public class EntryDto
    {

        /// <summary>
        /// The ID of the entry.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The date of the entry. Should not include a time portion.
        /// </summary>
        [Required]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The activity ID for the entry. The ID value should map to an ID in the activities collection.
        /// </summary>
        [Required]
        public int? ActivityId { get; set; }

        /// <summary>
        /// The duration for the entry (in minutes).
        /// </summary
        [Required]        
        public decimal? Duration { get; set; }

        /// <summary>
        /// The level of intensity for the entry.
        /// </summary>
        [Required]
        public Entry.IntensityLevel? Intensity { get; set; }

        /// <summary>
        /// Whether or not this entry should be excluded when calculating the total fitness activity.
        /// </summary>
        public bool Exclude { get; set; }

        /// <summary>
        /// The notes for the entry.
        /// </summary>
        [MaxLength(200, ErrorMessage = "The Notes field cannot be longer than 200 characters.")]
        public string Notes { get; set; }

        public Entry ToModel()
        {
            return new Entry
            {
                Id = Id,
                ActivityId = ActivityId.Value,
                Date = Date.Value,
                Duration = Duration.Value,
                Exclude = Exclude,
                Intensity = Intensity.Value,
                Notes = Notes
            };
        }
    }
}