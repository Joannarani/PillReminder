using System.Collections;
using System.Collections.Generic;

namespace Pill_Reminder
{
    public interface IStreamer<TKey, TValue>
    {
        void SaveData<T>(T dataToSave) where T : IDictionary<TKey, TValue>, ICollection;
        void SaveData(TValue dataToSave);
        TKey[] GetData();
    }
}
