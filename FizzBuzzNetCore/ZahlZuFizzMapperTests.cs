using FluentAssertions;

using Xunit;

namespace KataFizzBuzz.Durch3Teilbar
{
  public class Wenn_eine_durch_3_teilbare_Zahl_angefragt_wird
  {
    const int Durch3Teilbar = 3;
    readonly int _eingabe;
    readonly bool _kannDamitUmgehen;

    public Wenn_eine_durch_3_teilbare_Zahl_angefragt_wird()
    {
      var mapper = new ZahlZuFizzMapper();
      _eingabe = Durch3Teilbar;

      _kannDamitUmgehen = mapper.KannstDuDamitUmgehen(_eingabe);
    }

    [Fact]
    public void dann_ist_die_Antwort_Ja()
    {
      _kannDamitUmgehen.Should().BeTrue();
    }
  }

  public class Wenn_eine_nicht_durch_3_teilbare_Zahl_angefragt_wird
  {
    const int NichtDurch3Teilbar = 1;
    readonly int _eingabe;
    readonly bool _kannDamitUmgehen;

    public Wenn_eine_nicht_durch_3_teilbare_Zahl_angefragt_wird()
    {
      var mapper = new ZahlZuFizzMapper();
      _eingabe = NichtDurch3Teilbar;

      _kannDamitUmgehen = mapper.KannstDuDamitUmgehen(_eingabe);
    }

    [Fact]
    public void dann_ist_die_Antwort_Nein()
    {
      _kannDamitUmgehen.Should().BeFalse();
    }
  }

  public class Wenn_eine_durch_3_Zahl_gemappt_wird
  {
    const int Egal = 1;
    readonly int _eingabe;
    readonly string _ausgabe;

    public Wenn_eine_durch_3_Zahl_gemappt_wird()
    {
      var mapper = new ZahlZuFizzMapper();
      _eingabe = Egal;

      _ausgabe = mapper.Übersetzen(_eingabe);
    }

    [Fact]
    public void kommt_Fizz_raus()
    {
      _ausgabe.Should().Be("Fizz");
    }
  }

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
}
