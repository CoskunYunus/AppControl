using System;
using System.Collections.Generic;
using System.Text;

namespace Nuevo.Core.Infrastructure
{
    public class Result<T> : Result
    {
        public T Data { get; set; }
    }
    public class Result
    {
        public ResultType Status  { get; set; }
        public string Message { get; set; }
    }
}
