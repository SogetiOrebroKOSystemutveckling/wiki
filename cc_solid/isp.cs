public interface IList<T> 
{
    void Add(T item);
    void Remove(T item);
    T this[int index] { get; set; }
}

public class ReadOnlyList<T> : IList<T> 
{
    public void Add(T) 
    { 
        throw new NotSupportedException();
    }
    
    public void Remove(T) 
    { 
        throw new NotSupportedException();
    }
    
    T this[int index] 
    {
        { get... }
        { set... }
    }
}