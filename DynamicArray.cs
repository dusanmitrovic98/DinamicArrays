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

    public void Insert(int index, T item)
    {
        if (size == array.Length)
        {
            Array.Resize(ref array, array.Length * 2);
        }
        Array.Copy(array, index, array, index + 1, size - index);
        array[index] = item;
        size++;
    }

    public bool Remove(T item)
    {
        int index = IndexOf(item);
        if (index != -1)
        {
            RemoveAt(index);
            return true;
        }
        return false;
    }

    public void RemoveAt(int index)
    {
        Array.Copy(array, index + 1, array, index, size - index - 1);
        size--;
    }

    public void TrimExcess()
    {
        if (size < array.Length)
        {
            Array.Resize(ref array, size);
        }
    }

    public override string ToString()
    {
        var result = "";

        for (int i = 0; i < this.Capacity; i++)
        {
            if (i == 0)
            {
                result += "[" + this[i] + ", ";
                continue;
            }

            if (i == (this.Capacity - 1))
            {
                result += this[i] + "]";
                break;
            }

            result += this[i] + ", ";
        }

        return result;
    }
}
