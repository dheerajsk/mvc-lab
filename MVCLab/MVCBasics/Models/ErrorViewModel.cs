using System;

namespace MVCBasics.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string Content { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
