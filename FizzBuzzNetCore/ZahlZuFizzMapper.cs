namespace KataFizzBuzz.Durch3Teilbar;

public class ZahlZuFizzMapper : IMapper
{
  // 3 -> true
  // 1 -> false
  public bool KannstDuDamitUmgehen(int eingabe)
    => eingabe % 3 == 0;

  // irgendwas -> Fizz
  public string Übersetzen(int eingabe)
    => "Fizz";
}
