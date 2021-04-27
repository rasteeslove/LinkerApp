using System;
using ServiceStack;
using LinkerAppPrototype.ServiceModel;

namespace LinkerAppPrototype.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
