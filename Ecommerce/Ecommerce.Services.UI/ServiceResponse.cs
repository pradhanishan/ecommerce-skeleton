using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services.UI
{
    public sealed class ServiceResponse<T>
    {
        public bool IsSuccessful { get; set; }

        public int StatusCode { get; set; }

        public string Message { get; set; } = String.Empty;

        public T? Data { get; set; }


    }
}
