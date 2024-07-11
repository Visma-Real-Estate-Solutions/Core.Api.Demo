using CoreDemo.Client;
using CoreDemo.Models.Enums;

namespace CoreDemo;

public class CoreApiDemo
{
    private readonly CoreClient _coreClient;

    public CoreApiDemo(CoreClient coreClient)
    {
        _coreClient = coreClient;
    }

    public async Task Run()
    {
        // Call a function in _coreClient to get started.
        //await _coreClient.GetCaseInfo(66115);
        await Task.CompletedTask;
    }
}
