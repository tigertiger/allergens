using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergens;

namespace Allergens.Tests
{
  [TestClass]
  public class AllergenTests
  {
    [TestMethod]
    public void IsAllergen_Eggs_True()
    {
      {
    Allergen testAllergen = new Allergen();
    Assert.AreEqual(BigBookOfAllergens[1], testAllergen.IsAllergen("eggs"));
  }
    }
  }
}