namespace ShootingDice;
// TODO: Complete this class

// A Player that throws an exception when they lose to the other player
// Where might you catch this exception????
public class SoreLoserPlayer : Player
{
    public override void Play(Player other)
    {
        try
        {
            {
            base.Roll();
            }
        }
        catch (System.Exception e)
        {
            Console.WriteLine(e);
        }
    }
}