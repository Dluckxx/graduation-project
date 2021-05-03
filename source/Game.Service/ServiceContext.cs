using Game.Presentation.Area;
using System.Collections.Generic;

namespace Game.Service
{
    public class ServiceContext : ServiceBase
    {
        public override string Name { get { return "ServiceContext"; } }

        // Store all services
        List<ServiceBase> mServices = new List<ServiceBase>();

        // All single service property
        private AreaService areaService { get; }

        public ServiceContext()
        {
            // Init services
            areaService = new AreaService();
        }

        public override void Setup()
        {
            
            // All services setup
            foreach(ServiceBase service in mServices){
                service.Setup();
            }
        }

        public override void Teardown()
        {

            // All services tear down
            foreach (ServiceBase service in mServices)
            {
                service.Teardown();
            }
        }

        public override void Tick()
        {

            // All services tick
            foreach (ServiceBase service in mServices)
            {
                service.Tick();
            }
        }
    }
}