namespace CoreDemo.Models;

/// <summary>
/// Used to return pure values as a json object
/// </summary>
public class TypeResult<T>
{
    public T? Value { get; set; }
}
