using Game.Presentation.Area;
using System.Collections.Generic;

namespace Game.Service
{
    public static class ServiceContext
    {
        static List<ServiceBase> mServices = new List<ServiceBase>();

        // All single service property
        public static readonly AreaService AreaService = new AreaService();


        public static void Setup()
        {
            AddServices();
            // All services setup
            foreach (ServiceBase service in mServices){
                service.Setup();
            }
        }

        public static void Teardown()
        {

            // All services tear down
            foreach (ServiceBase service in mServices)
            {
                service.Teardown();
            }
        }

        public static void Tick()
        {

            // All services tick
            foreach (ServiceBase service in mServices)
            {
                service.Tick();
            }
        }

        private static void AddServices()
        {
            mServices.Add(AreaService);
        }
    }
}