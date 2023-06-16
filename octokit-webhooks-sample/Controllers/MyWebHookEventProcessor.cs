
using Octokit.Webhooks;
using Octokit.Webhooks.Events;

public sealed class MyWebhookEventProcessor : WebhookEventProcessor
{
    private readonly ILogger<MyWebhookEventProcessor> logger;

    public MyWebhookEventProcessor(ILogger<MyWebhookEventProcessor> logger) => this.logger = logger;

    protected override async Task ProcessPushWebhookAsync(WebhookHeaders headers, PushEvent pushEvent)
    {
        this.logger.LogInformation("Push event received");

        // Handle the push event here

        await Task.Delay(1000);
    }
}