﻿namespace DataStructures.Collections.DynamicArray;

public class DynamicArray<T>
{
    private T[] array;
    private int size;

    public DynamicArray(int capacity)
    {
        this.array = new T[capacity];
        this.size = 0;
    }
}
