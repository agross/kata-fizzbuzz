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

  public class Wenn_eine_nicht_durch_3_teilbare_Zahl_gemappt_wird
  {
    const int NichtDurch3Teilbar = 1;
    readonly int _eingabe;
    readonly string _ausgabe;

    public Wenn_eine_nicht_durch_3_teilbare_Zahl_gemappt_wird()
    {
      var mapper = new ZahlZuFizzMapper();
      _eingabe = NichtDurch3Teilbar;

      _ausgabe = mapper.Übersetzen(_eingabe);
    }

    [Fact]
    public void kommt_die_Zahl_als_String_zurück()
    {
      _ausgabe.Should().Be(_eingabe.ToString());
    }
  }

  public class ZahlZuFizzMapper
  {
    // 3 -> Fizz
    // 1 -> null (false)
    public string Übersetzen(int eingabe)
    {
      if (eingabe % 3 == 0)
      {
        return "Fizz";
      }

      return eingabe.ToString();
    }
  }
}
