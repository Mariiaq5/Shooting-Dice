using System.Dynamic;
using System.Reflection.Metadata;

namespace ShootingDice;
// A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
public class CreativeSmackTalkingPlayer : Player
{
    private List<string> _Taunts {get;} = new List<string>()
    {
        "Yo baby! Selam and bye!",
        "Yo-yo crazy!"
    };

    public override int Roll()
    {
        int RandomTaunt = new Random().Next(_Taunts.Count);
        Console.WriteLine(_Taunts[RandomTaunt]);
        return base.Roll();
    }
}