using Fluent;

/// <summary>
/// There are two things explained in this example.
/// The first is that we now inherit from MyConversation which contains the code to stop the player from moving
/// The second is that concept of chaining responses, they will each be executed from Start() to End()
/// </summary>
public class Conversation2 : MyFluentDialogue
{
    public override FluentNode Create()
    {
        return
            Yell("I love ...") *
            Yell("CAKE!") *
            Yell("And chained responses!");
    }
}
