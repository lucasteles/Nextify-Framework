﻿namespace  Nextify.Abstraction
{
    public interface IModelWithKey : IModelWithKey<int>
    {

    }

    public interface IModelWithKey<TKey>
    {
        TKey Id { get; set; }
    }
}
