namespace DataStructures.Collections.DynamicArray;

public interface IDynamicArray<T>
{
    public int Size { get; }
    public int Capacity { get; }
    public void Add(T item);
    public void Clear();
    public bool Contains(T item);
    public int IndexOf(T item);
    public bool Remove(T item);
    public void RemoveAt(int index);
    public void TrimExcess();
}