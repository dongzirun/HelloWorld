using System;
using System.ComponentModel.DataAnnotations;

namespace GI.Web.Models
{
    public class ErrorViewModel
    {
        [Required]
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}