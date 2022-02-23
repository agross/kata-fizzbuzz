namespace KataFizzBuzz.Durch15Teilbar;

public class ZahlZuFizzBuzzMapper : IMapper
{
  // 15 -> true
  // 1 -> false
  public bool KannstDuDamitUmgehen(int eingabe)
    => eingabe % 15 == 0;

  // irgendwas -> Buzz
  public string Übersetzen(int eingabe)
    => "FizzBuzz";
}
