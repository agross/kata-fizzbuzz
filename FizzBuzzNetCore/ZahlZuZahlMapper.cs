namespace KataFizzBuzz.ZahlZuZahl;

public class ZahlZuZahlMapper : IMapper
{
  public bool KannstDuDamitUmgehen(int eingabe)
    => true;

  public string Übersetzen(int eingabe)
    => eingabe.ToString();
}
