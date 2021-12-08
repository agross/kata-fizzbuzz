using FluentAssertions;

using Xunit;

namespace KataFizzBuzz
{
  public class Wenn_eine_Zahl_gemappt_wird
  {
    const int Egal = 42;
    int _eingabe;
    string _ausgabe;

    public Wenn_eine_Zahl_gemappt_wird()
    {
      var mapper = new ZahlZuZahlMapper();
      _eingabe = Egal;

      _ausgabe = mapper.Übersetzen(_eingabe);
    }

    [Fact]
    public void kommt_die_Zahl_als_String_zurück()
    {
      _ausgabe.Should().Be(_eingabe.ToString());
    }
  }

  public class ZahlZuZahlMapper
  {
    public string Übersetzen(int eingabe)
      => eingabe.ToString();
  }
}
