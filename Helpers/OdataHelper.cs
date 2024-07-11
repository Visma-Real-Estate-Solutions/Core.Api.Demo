using CoreDemo.Models;

namespace CoreDemo.Helpers;

public class OdataHelper
{
    public static string GetOdataFilter(string filter)
    {
        return string.IsNullOrEmpty(filter) ? string.Empty : $"$filter={filter}";
    }

    public static string GetOdataOrderBy(string orderBy)
    {
        return string.IsNullOrEmpty(orderBy) ? string.Empty : $"$orderby={orderBy}";
    }

    public static string GetOdataTop(int top)
    {
        return top == 0 ? string.Empty : $"$top={top}";
    }

    public static string GetOdataSkip(int skip)
    {
        return skip == 0 ? string.Empty : $"$skip={skip}";
    }

    public static string GetOdataCount(bool count)
    {
        return count ? "$count=true" : string.Empty;
    }

    /// <summary>
    /// Returns the number of pages in a result set
    /// </summary>
    /// <param name="result">OData response</param>
    /// <typeparam name="T">Some Dto</typeparam>
    /// <returns>Number of pages</returns>
    public static int GetPageCount<T>(InlineCountDto<T> result)
    {
        var totalResults = result.Count;
        var responseLength = result.Results.Count();

        return responseLength > 0 && totalResults % responseLength != 0
            ? (totalResults / responseLength) + 1
            : totalResults / responseLength;
    }
}
