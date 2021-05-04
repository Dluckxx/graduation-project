namespace Game.Service
{
    public abstract class ServiceBase
    {
        public virtual string Name { get { return "ServiceBase"; } }

        public virtual void Setup() { }

        public virtual void Teardown() { }

        public virtual void Tick() { }
    }
}