using System;
using System.ComponentModel.DataAnnotations;

namespace AksiApi.Entities
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public string ApplicationName { get; set; }
        public string Email { get; set; }
        [RegularExpression(@"(.*?)\.(png|mp3|tiff|xls|pdf)$")]
        public string Filename { get; set; }
        [Url]
        public string Url { get; set; }
        public DateTime Inception { get; set; }
        public decimal Amount { get; set; }
        public decimal? Allocation { get; set; }
    }
}
