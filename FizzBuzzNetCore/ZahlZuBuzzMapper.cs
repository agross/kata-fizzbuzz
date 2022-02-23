namespace KataFizzBuzz.Durch5Teilbar;

public class ZahlZuBuzzMapper : IMapper
{
  // 5 -> true
  // 1 -> false
  public bool KannstDuDamitUmgehen(int eingabe)
    => eingabe % 5 == 0;

  // irgendwas -> Buzz
  public string Übersetzen(int eingabe)
    => "Buzz";
}
