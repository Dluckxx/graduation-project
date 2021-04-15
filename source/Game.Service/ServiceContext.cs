using System.Collections.Generic;

namespace Game.Service
{
    public class ServiceContext
    {
        Dictionary<string, ServiceBase> mServices = new Dictionary<string, ServiceBase>();

        public void AddService(ServiceBase service)
        {
            mServices.Add(service.Name, service);
        }

        public bool TryGetService(string ServiceName, out ServiceBase service)
        {
            return mServices.TryGetValue(ServiceName, out service);
        }

        public void Tick()
        {
            
        }
    }
}