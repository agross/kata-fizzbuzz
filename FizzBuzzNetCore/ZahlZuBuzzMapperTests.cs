using FluentAssertions;

using Xunit;

namespace KataFizzBuzz.Durch5Teilbar
{
  public class Wenn_eine_durch_5_teilbare_Zahl_angefragt_wird
  {
    const int Durch5Teilbar = 5;
    readonly int _eingabe;
    readonly bool _kannDamitUmgehen;

    public Wenn_eine_durch_5_teilbare_Zahl_angefragt_wird()
    {
      var mapper = new ZahlZuBuzzMapper();
      _eingabe = Durch5Teilbar;

      _kannDamitUmgehen = mapper.KannstDuDamitUmgehen(_eingabe);
    }

    [Fact]
    public void dann_ist_die_Antwort_Ja()
    {
      _kannDamitUmgehen.Should().BeTrue();
    }
  }

  public class Wenn_eine_nicht_durch_5_teilbare_Zahl_angefragt_wird
  {
    const int NichtDurch5Teilbar = 1;
    readonly int _eingabe;
    readonly bool _kannDamitUmgehen;

    public Wenn_eine_nicht_durch_5_teilbare_Zahl_angefragt_wird()
    {
      var mapper = new ZahlZuBuzzMapper();
      _eingabe = NichtDurch5Teilbar;

      _kannDamitUmgehen = mapper.KannstDuDamitUmgehen(_eingabe);
    }

    [Fact]
    public void dann_ist_die_Antwort_Nein()
    {
      _kannDamitUmgehen.Should().BeFalse();
    }
  }

  public class Wenn_eine_Zahl_gemappt_wird
  {
    const int Egal = 1;
    readonly int _eingabe;
    readonly string _ausgabe;

    public Wenn_eine_Zahl_gemappt_wird()
    {
      var mapper = new ZahlZuBuzzMapper();
      _eingabe = Egal;

      _ausgabe = mapper.Übersetzen(_eingabe);
    }

    [Fact]
    public void kommt_Buzz_raus()
    {
      _ausgabe.Should().Be("Buzz");
    }
  }

  public class ZahlZuBuzzMapper : IMapper
  {
    // 5 -> true
    // 1 -> false
    public bool KannstDuDamitUmgehen(int eingabe)
      => eingabe % 5 == 0;

    // irgenwas -> Buzz
    public string Übersetzen(int eingabe)
      => "Buzz";
  }
}
