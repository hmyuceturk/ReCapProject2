using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>, IDataResult<T>
    {
        public SuccessDataResult(T data) : base(true, data)
        {
            
        }

        public SuccessDataResult(string message, T data) : base(true, message, data)
        {
        }
    }
}
