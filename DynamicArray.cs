namespace DataStructures.Collections.DynamicArray;

public class DynamicArray<T> : IDynamicArray
{
    private T[] array;
    private int size;

    public DynamicArray(int capacity)
    {
        this.array = new T[capacity];
        this.size = 0;
    }

    public int Size
    {
        get { return this.size; }
    }

    public int Capacity
    {
        get { return this.array.Length; }
    }
}
