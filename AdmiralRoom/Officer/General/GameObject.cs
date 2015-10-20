﻿namespace Huoyaoyuan.AdmiralRoom.Officer
{
    public abstract class GameObject<T> : NotifyBase, IUpdatable<T>, IIdentifiable
    {
        protected T rawdata;
        public GameObject() { }
        public GameObject(T data)
        {
            rawdata = data;
            UpdateProp();
        }
        public void Update(T data)
        {
            rawdata = data;
            UpdateProp();
            OnAllPropertyChanged();
        }
        protected virtual void UpdateProp() { }
        public abstract int Id { get; }
    }
}