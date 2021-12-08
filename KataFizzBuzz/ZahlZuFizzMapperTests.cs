using FluentAssertions;

using Xunit;

namespace KataFizzBuzz
{
  public class Wenn_eine_durch_3_teilbare_Zahl_gemappt_wird
  {
    const int Durch3Teilbar = 3;
    readonly int _eingabe;
    readonly string _ausgabe;

    public Wenn_eine_durch_3_teilbare_Zahl_gemappt_wird()
    {
      var mapper = new ZahlZuFizzMapper();
      _eingabe = Durch3Teilbar;

      _ausgabe = mapper.Übersetzen(_eingabe);
    }

    [Fact]
    public void kommt_Fizz_raus()
    {
      _ausgabe.Should().Be("Fizz");
    }
  }

  public class ZahlZuFizzMapper
  {
    public string Übersetzen(int eingabe)
    {
      return "Fizz";
    }
  }
}
