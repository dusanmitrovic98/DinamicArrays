﻿namespace DataStructures.Collections.DynamicArray;

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
}
