using System;
using System.Collections.Generic;
using System.Linq;

using FluentAssertions;

using Xunit;


// Red, Green, Refactor
namespace KataFizzBuzz
{
  public class Wenn_die_Zahlen_abgerufen_wird
  {
    readonly IEnumerable<int> _zahlen;

    // Arrange + Act
    public Wenn_die_Zahlen_abgerufen_wird()
    {
      var generator = new ZahlenGenerator();

      _zahlen = generator.GibMirDieZahlen();
    }

    [Fact]
    // NUnit: [Test]
    public void soll_die_erste_1_sein()
    {
      _zahlen.First().Should().Be(1);
    }

    [Fact]
    // NUnit: [Test]
    public void soll_die_letzte_100_sein()
    {
      _zahlen.Last().Should().Be(100);
    }

    [Fact]
    public void sollen_es_100_Zahlen_sein()
    {
      // _zahlen.Count().Should().Be(100);
      _zahlen.Should().HaveCount(100);
    }
  }
}
