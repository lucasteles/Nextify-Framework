namespace Pragma.Core
{
    public interface IModelWithId : IModelWithId<int>
    {

    }

    public interface IModelWithId<TKey>
    {
        TKey Id { get; set; }
    }
}
