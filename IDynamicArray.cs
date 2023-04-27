namespace DataStructures.Collections.DynamicArray;

public interface IDynamicArray<T>
{
    public int Size { get; }
    public int Capacity { get; }
    public void Add(T item);
    public void Clear();
    public bool Contains(T item);
}