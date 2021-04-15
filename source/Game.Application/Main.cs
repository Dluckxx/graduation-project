using Game.Service;
using UnityEngine;

namespace Game.Application{
    public class Main : ISetup
    {
        ServiceContext mServiceContext = new ServiceContext();

        public Main()
        {
            
        }

        public void Setup()
        {
            mServiceContext.AddService(new TestService());
        }

        public void TearDown()
        {
            
        }

        public void Tick()
        {
            
        }
    }
}