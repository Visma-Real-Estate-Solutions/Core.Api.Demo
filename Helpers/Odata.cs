namespace CoreDemo.Helpers;

public class Odata
{
    private readonly string _top;
    private readonly string _skip;
    private readonly string _filter;
    private readonly string _orderBy;
    private readonly string _count;

    public override string ToString()
    {
        var query = "";
        query += Add(_filter, query);
        query += Add(_orderBy, query);
        query += Add(_top, query);
        query += Add(_skip, query);
        query += Add(_count, query);
        return query;
    }

    /// <summary>
    /// Create a new Odata object with the given parameters.
    /// Use ToString to get raw query string.
    /// </summary>
    /// <param name="top">The max top varies between endpoints - you will get a bad-request if you go over this</param>
    /// <param name="skip">Skip the first x elements</param>
    /// <param name="filter"></param>
    /// <param name="orderBy"></param>
    /// <param name="count">Include the number of results in the response.
    /// Note: When we include count, the response from backend changes to include count and results, instead of the pure results only.</param>
    public Odata(int top = 0, int skip = 0, string filter = "", string orderBy = "", bool count = false)
    {
        _top = OdataHelper.GetOdataTop(top);
        _skip = OdataHelper.GetOdataSkip(skip);
        _filter = OdataHelper.GetOdataFilter(filter);
        _orderBy = OdataHelper.GetOdataOrderBy(orderBy);
        _count = OdataHelper.GetOdataCount(count);
    }

    private string Add(string param, string query)
    {
        if (string.IsNullOrEmpty(query) && !string.IsNullOrEmpty(param))
            return $"?{param}";
        if (!string.IsNullOrEmpty(query) && !string.IsNullOrEmpty(param))
            return $"&{param}";

        return "";
    }
}
