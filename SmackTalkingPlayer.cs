namespace ShootingDice;
// TODO: Complete this class

// A Player who shouts a taunt every time they roll dice
public class SmackTalkingPlayer : Player
{
    public string Taunt { get; }

    public void SmackTalking()
    {
        Console.WriteLine(this.Name + " says you're gonna lose");
    }
}