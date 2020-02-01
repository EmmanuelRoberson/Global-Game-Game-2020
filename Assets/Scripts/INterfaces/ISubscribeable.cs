using UnityEngine;

namespace INterfaces
{
    public interface ISubscribeable
    {
        void AddListener(IListener listener);
        void RemoveListener(IListener listener);
        void Raise(params Object[] obj);
        void Raise();
    }
}
