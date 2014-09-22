﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Data.Exceptions
{
    [Serializable]
    public class RootObjectNotFoundException : Exception
    {
        public RootObjectNotFoundException(string message)
            : base(message)
        {
        }
    }
}
