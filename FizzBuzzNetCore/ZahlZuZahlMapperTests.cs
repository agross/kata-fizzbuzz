using FluentAssertions;

using Xunit;

namespace KataFizzBuzz.ZahlZuZahl
{
  public class Wenn_irgendeine_Zahl_angefragt_wird
  {
    const int Egal = 1;
    readonly int _eingabe;
    readonly bool _kannDamitUmgehen;

    public Wenn_irgendeine_Zahl_angefragt_wird()
    {
      var mapper = new ZahlZuZahlMapper();
      _eingabe = Egal;

      _kannDamitUmgehen = mapper.KannstDuDamitUmgehen(_eingabe);
    }

    [Fact]
    public void dann_ist_die_Antwort_Ja()
    {
      _kannDamitUmgehen.Should().BeTrue();
    }
  }

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
}
