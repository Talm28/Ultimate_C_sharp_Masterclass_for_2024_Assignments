IDataDownloader dataDownloader = new DataDownloaderWithCache(new SlowDataDownloader());

Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));

Console.ReadKey();

public interface IDataDownloader
{
    string DownloadData(string resourceId);
}

public class DataDownloaderWithCache : IDataDownloader
{
    private readonly IDataDownloader _dataDownloader;
    private readonly CustomCache<string, string> _cache = new CustomCache<string, string>();

    public DataDownloaderWithCache(IDataDownloader dataDownloader)
    {
        _dataDownloader = dataDownloader;
    }

    public string DownloadData(string resourceId)
    {
        return _cache.GetData(resourceId, _dataDownloader.DownloadData);
    }
}

public class SlowDataDownloader : IDataDownloader
{
    public string DownloadData(string resourceId)
    {
        //let's imagine this method downloads real data,
        //and it does it slowly
        Thread.Sleep(1000);
        return  $"Some data for {resourceId}";
    }
}

public class CustomCache<TKey, TValue> where TKey : notnull
{
    private Dictionary<TKey, TValue> _cache = new Dictionary<TKey, TValue>();

    public TValue GetData(TKey key, Func<TKey, TValue> getValue)
    {
        if(_cache.ContainsKey(key))
        {
            return _cache[key];
        }
        _cache[key] = getValue(key);
        return _cache[key];
    }
}
