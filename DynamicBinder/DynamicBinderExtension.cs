﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Toolbelt.DynamicBinderExtension
{
    public static class DynamicBinderExtension
    {
        public static LateBinder ToLateBind(this object self)
        {
            return new LateBinder(self);
        }

        public static dynamic ToDynamic(this object self)
        {
            return new DynamicBinder(new LateBinder(self));
        }
    }
}
