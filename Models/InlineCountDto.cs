namespace CoreDemo.Models;

public class InlineCountDto<T>
{
    public required int Count { get; set; }
    public required IEnumerable<T> Results { get; set; } = new List<T>();
}
