using FakeItEasy;

using FluentAssertions;

using KataFizzBuzz;

using Xunit;

namespace FizzBuzzNetCore;

public class Wenn_eine_Zahl_übersetzt_wird
{
  readonly IMapper _wirdGenutzt;
  WirdNichtGenutzt _wirdNichtGenutzt1;
  WirdNichtGenutzt _wirdNichtGenutzt2;
  readonly string _ausgabe;

  class WirdNichtGenutzt : IMapper
  {
    public bool IchWurdeGefragt { get; private set; }

    public bool KannstDuDamitUmgehen(int eingabe)
    {
      IchWurdeGefragt = true;

      return false;
    }

    public string Übersetzen(int eingabe)
      => throw new NotImplementedException();
  }

  class WirdGenutzt : IMapper
  {
    public bool IchWurdeGefragt { get; private set; }

    public bool IchWurdeAufgerufen { get; private set; }

    public bool KannstDuDamitUmgehen(int eingabe)
    {
      IchWurdeGefragt = true;

      return true;
    }

    public string Übersetzen(int eingabe)
    {
      IchWurdeAufgerufen = true;

      return AusgabeFürEgal;
    }
  }

  const int Egal = 1;
  const string AusgabeFürEgal = "ich wurde genutzt";

  public Wenn_eine_Zahl_übersetzt_wird()
  {
    // Arrange
    _wirdNichtGenutzt1 = new WirdNichtGenutzt();
    _wirdNichtGenutzt2 = new WirdNichtGenutzt();

    _wirdGenutzt = A.Fake<IMapper>();
    A.CallTo(() => _wirdGenutzt.KannstDuDamitUmgehen(Egal))
     .Returns(true);

    A.CallTo(() => _wirdGenutzt.Übersetzen(Egal))
     .Returns(AusgabeFürEgal);


    var mapper = new IMapper[]
    {
      _wirdNichtGenutzt1,
      _wirdGenutzt,
      _wirdNichtGenutzt2
    };

    // sut = System Under Test.
    var sut = new KataFizzBuzz(mapper);

    // Act
    _ausgabe = sut.Übersetzen(Egal);
  }

  [Fact]
  void dann_sollen_Mapper_bis_zum_ersten_Treffer_gefragt_werden_ob_sie_etwas_mit_der_Eingabe_anfangen_können()
  {
    _wirdNichtGenutzt1.IchWurdeGefragt.Should().BeTrue();

    // _wirdGenutzt.IchWurdeGefragt.Should().BeTrue();
    A.CallTo(() => _wirdGenutzt.KannstDuDamitUmgehen(Egal))
     .MustHaveHappened();

    _wirdNichtGenutzt2.IchWurdeGefragt.Should().BeFalse();
  }

  [Fact]
  void dann_der_erste_Mapper_der_etwas_mit_der_Zahl_anfangen_kann_genutzt_werden()
  {
    // _wirdGenutzt.IchWurdeAufgerufen.Should().BeTrue();
    A.CallTo(() => _wirdGenutzt.Übersetzen(Egal))
     .MustHaveHappened();
  }

  [Fact]
  void dann_soll_das_Ergebnis_die_Ausgabe_sein()
  {
    _ausgabe.Should().Be(AusgabeFürEgal);
  }
}

// Was ist wenn es keine IMapper[] gibt?
