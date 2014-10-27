using Akka.Dispatch;

namespace Akka.Actor
{
    /// <summary>
    /// Lets the <see cref="StashFactory"/> know that this Actor needs stash support
    /// with unrestricted storage capacity.
    /// You need to add the property:
    /// <pre><code>public IStash Stash { get; set; }</code></pre>
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public interface WithUnboundedStash : IActorStash, RequiresMessageQueue<UnboundedDequeBasedMessageQueueSemantics>
    {
    }
}