
namespace Pill_Reminder
{
    public interface IControler<T>
    {
        void Add(T element);
        void Remove(T element);
        void Stop();
    }
}
