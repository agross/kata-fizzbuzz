using FluentAssertions;

using Xunit;

namespace KataFizzBuzz.Durch15Teilbar
{
  public class Wenn_eine_durch_15_teilbare_Zahl_angefragt_wird
  {
    const int Durch15Teilbar = 15;
    readonly int _eingabe;
    readonly bool _kannDamitUmgehen;

    public Wenn_eine_durch_15_teilbare_Zahl_angefragt_wird()
    {
      var mapper = new ZahlZuFizzBuzzMapper();
      _eingabe = Durch15Teilbar;

      _kannDamitUmgehen = mapper.KannstDuDamitUmgehen(_eingabe);
    }

    [Fact]
    public void dann_ist_die_Antwort_Ja()
    {
      _kannDamitUmgehen.Should().BeTrue();
    }
  }

  public class Wenn_eine_nicht_durch_15_teilbare_Zahl_angefragt_wird
  {
    const int NichtDurch15Teilbar = 1;
    readonly int _eingabe;
    readonly bool _kannDamitUmgehen;

    public Wenn_eine_nicht_durch_15_teilbare_Zahl_angefragt_wird()
    {
      var mapper = new ZahlZuFizzBuzzMapper();
      _eingabe = NichtDurch15Teilbar;

      _kannDamitUmgehen = mapper.KannstDuDamitUmgehen(_eingabe);
    }

    [Fact]
    public void dann_ist_die_Antwort_Nein()
    {
      _kannDamitUmgehen.Should().BeFalse();
    }
  }

  public class Wenn_eine_durch_15_teilbare_Zahl_gemappt_wird
  {
    const int Egal = 1;
    readonly int _eingabe;
    readonly string _ausgabe;

    public Wenn_eine_durch_15_teilbare_Zahl_gemappt_wird()
    {
      var mapper = new ZahlZuFizzBuzzMapper();
      _eingabe = Egal;

      _ausgabe = mapper.Übersetzen(_eingabe);
    }

    [Fact]
    public void kommt_FizzBuzz_raus()
    {
      _ausgabe.Should().Be("FizzBuzz");
    }
  }

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
}
