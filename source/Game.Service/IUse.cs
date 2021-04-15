namespace Game.Service
{
    public interface IUse<T>
    {
        void Bind(T service);

        void UnBind();
    }
}