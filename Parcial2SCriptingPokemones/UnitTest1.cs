using Parcial2SCriptingPokemones.Source;

namespace Parcial2SCriptingPokemones
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestInstantiatePokemon_DefaultValues()
        {
            // Arrange
            Pokemon pikachu = new Pokemon("Pikachu", PokemonType.Electric);

            // Assert
            Assert.AreEqual(1, pikachu.Level);
            Assert.AreEqual(10, pikachu.Attack);
            Assert.AreEqual("Pikachu", pikachu.Name);
        }

        [TestCase(PokemonType.Water, PokemonType.Fire, 2.0)]
        [TestCase(PokemonType.Electric, PokemonType.Ground, 0.0)]
        public void TestTypeModifier_SingleType(PokemonType attackingType, PokemonType defendingType, double expectedMod)
        {
            // Arrange
            Move attack = new Move("Water Gun", attackingType, MoveType.Special);
            Pokemon defender = new Pokemon("Charizard", defendingType);

            // Act
            double actualMod = TypeCalculator.CalculateMod(attack.Type, defender.Types);

            // Assert
            Assert.AreEqual(expectedMod, actualMod);
        }

        [TestCase(1, 1, 1, 1, 1, 0, ExpectedResult = 0)]
        [TestCase(2, 5, 50, 50, 1, 16, ExpectedResult = 16)]
        // ... y así sucesivamente para los 40 casos de prueba
        public int TestDamageFormula(int attackingLv, int movePwr, int attackingStat, int defendingStat, int mod, int expectedDmg)
        {
            // Arrange
            // Crea instancias de Pokémon y Move con los parámetros de la prueba
            Pokemon attacker = new Pokemon("Attacker", PokemonType.Bug) { Level = attackingLv, Attack = attackingStat };
            Pokemon defender = new Pokemon("Defender", PokemonType.Psychic) { Defense = defendingStat };
            Move physicalMove = new Move("Physical Attack", PokemonType.Bug, MoveType.Physical);

            // Act
            int actualDmg = DamageCalculator.Calculate(attacker, defender, physicalMove, mod);

            // ¡Devuelve el valor calculado para que NUnit lo compare con ExpectedResult!
            return actualDmg;
        }
    }
}