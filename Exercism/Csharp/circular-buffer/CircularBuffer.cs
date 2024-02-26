using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class CircularBuffer<T>
{
    private readonly int _capacity;
    private readonly Queue<T> _queue;

    public CircularBuffer(int capacity)
    {
        _capacity = capacity;
        _queue = new Queue<T>(capacity);
    }

    public T Read()
    {
        return _queue.Dequeue();
    }

    public void Write(T value)
    {
        if (_queue.Count == _capacity)
        {
            throw new InvalidOperationException("No se pueden añadir mas elementos, sobreescribe");
        }
        _queue.Enqueue(value);
    }

    public void Overwrite(T value)
    {
        if (_queue.Count == _capacity)
        {
            _queue.Dequeue();
        }
        _queue.Enqueue(value);
    }

    public void Clear()
    {
        _queue.Clear();
    }
}