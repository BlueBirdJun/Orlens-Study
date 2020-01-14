using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Common.Middleware
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class RegisterAttribute : Attribute
    {
        public Type RegistrationType { get; }

        public RegisterAttribute(Type registrationType)
        {
            this.RegistrationType = registrationType;
        }
    }
}
