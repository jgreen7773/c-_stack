using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace validate_form_submit.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}