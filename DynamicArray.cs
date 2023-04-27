namespace DataStructures.Collections.DynamicArray;

public class DynamicArray<T> : IDynamicArray<T>
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

    public T this[int index]
    {
        get { return this.array[index]; }
        set { this.array[index] = value; }
    }

    public void Add(T item)
    {
        if (this.size == this.array.Length)
        {
            Array.Resize(ref this.array, this.array.Length * 2);
        }

        this.array[size++] = item;
    }

    public void Clear()
    {
        Array.Clear(this.array, 0, this.size);
        this.size = 0;
    }

    public bool Contains(T item)
    {
        for (int i = 0; i < size; i++)
        {
            if (EqualityComparer<T>.Default.Equals(array[i], item))
            {
                return true;
            }
        }
        return false;
    }

    public int IndexOf(T item)
    {
        for (int i = 0; i < size; i++)
        {
            if (EqualityComparer<T>.Default.Equals(array[i], item))
            {
                return i;
            }
        }
        return -1;
    }
}
