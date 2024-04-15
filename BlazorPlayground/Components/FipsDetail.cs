namespace BlazorPlayground.Components;

public record FipsDetail
{
    
};

public class FipsDetailQuery
{
}

public class FipsService
{
    public async Task<FipsDetail?> GetFipsDetail(FipsDetailQuery query)
    {
        return new FipsDetail();
    }
}