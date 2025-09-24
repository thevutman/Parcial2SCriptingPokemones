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

        // Casos 1-10
        [TestCase(1, 1, 1, 1, 1, 1, 0, ExpectedResult = 0)]
        [TestCase(2, 1, 1, 1, 1, 1, ExpectedResult = 1)]
        [TestCase(3, 5, 50, 100, 50, 2, ExpectedResult = 16)]
        [TestCase(4, 5, 50, 100, 50, 1, ExpectedResult = 5)]
        [TestCase(5, 10, 20, 30, 15, 1, ExpectedResult = 5)]
        [TestCase(6, 12, 40, 60, 80, 2, ExpectedResult = 9)]
        [TestCase(7, 25, 80, 120, 60, 1, ExpectedResult = 40)]
        [TestCase(8, 30, 100, 50, 100, 4, ExpectedResult = 58)]
        [TestCase(9, 40, 150, 200, 150, 1, ExpectedResult = 37)]
        [TestCase(10, 50, 128, 200, 100, 1, ExpectedResult = 58)]

        // Casos 11-20
        [TestCase(11, 50, 128, 200, 100, 4, ExpectedResult = 455)]
        [TestCase(12, 60, 200, 250, 200, 1, ExpectedResult = 132)]
        [TestCase(13, 70, 180, 200, 100, 2, ExpectedResult = 435)]
        [TestCase(14, 80, 90, 45, 90, 1, ExpectedResult = 33)]
        [TestCase(15, 90, 255, 200, 50, 2, ExpectedResult = 1554)]
        [TestCase(16, 99, 255, 255, 1, 2, ExpectedResult = 108206)]
        [TestCase(17, 99, 255, 255, 255, 4, ExpectedResult = 856)]
        [TestCase(18, 99, 255, 255, 255, 0, ExpectedResult = 0)]
        [TestCase(19, 99, 255, 1, 255, 1, ExpectedResult = 2)]
        [TestCase(20, 45, 60, 10, 200, 1, ExpectedResult = 2)]

        // Casos 21-30
        [TestCase(21, 20, 30, 5, 250, 1, ExpectedResult = 1)]
        [TestCase(22, 2, 10, 1, 255, 1, ExpectedResult = 1)]
        [TestCase(23, 3, 5, 2, 3, 1, ExpectedResult = 1)]
        [TestCase(24, 15, 200, 255, 255, 1, ExpectedResult = 33)]
        [TestCase(25, 16, 200, 255, 254, 1, ExpectedResult = 34)]
        [TestCase(26, 17, 200, 255, 128, 1, ExpectedResult = 36)]
        [TestCase(27, 33, 77, 77, 77, 1, ExpectedResult = 25)]
        [TestCase(28, 48, 33, 99, 11, 4, ExpectedResult = 508)]
        [TestCase(29, 55, 44, 88, 22, 1, ExpectedResult = 44)]
        [TestCase(30, 66, 11, 11, 11, 1, ExpectedResult = 8)]

        // Casos 31-40
        [TestCase(31, 77, 123, 200, 100, 2, ExpectedResult = 326)]
        [TestCase(32, 88, 200, 100, 50, 4, ExpectedResult = 1197)]
        [TestCase(33, 10, 200, 200, 200, 0, ExpectedResult = 0)]
        [TestCase(34, 50, 255, 100, 50, 0, ExpectedResult = 0)]
        [TestCase(35, 75, 180, 255, 180, 0, ExpectedResult = 0)]
        [TestCase(36, 99, 255, 255, 1, 0, ExpectedResult = 0)]
        [TestCase(37, 25, 60, 40, 20, 0, ExpectedResult = 0)]
        [TestCase(38, 60, 100, 255, 128, 1, ExpectedResult = 40)]
        [TestCase(39, 80, 90, 45, 90, 1, ExpectedResult = 17)]
        [TestCase(40, 99, 200, 150, 150, 1, ExpectedResult = 84)]

        public int TestDamageFormula(int testCaseId, int attackingLv, int movePwr, int attackingStat, int defendingStat, double mod, int expectedDmg)
        {
            // ARRANGE
            MoveType moveType;
            if (testCaseId % 2 != 0)
            {
                moveType = MoveType.Special;
            }
            else
            {
                moveType = MoveType.Physical;
            }

            // Crear instancias genéricas de Pokémon para la prueba.
            Pokemon attacker = new Pokemon("Attacker", PokemonType.Bug) { Level = attackingLv };
            Pokemon defender = new Pokemon("Defender", PokemonType.Rock) { Defense = defendingStat, SpecialDefense = defendingStat };

            // Asignar la estadística de ataque y defensa correcta según el tipo de movimiento.
            if (moveType == MoveType.Physical)
            {
                attacker.Attack = attackingStat;
                defender.Defense = defendingStat;
            }
            else
            {
                attacker.SpecialAttack = attackingStat;
                defender.SpecialDefense = defendingStat;
            }

            // Define el movimiento con el poder base y el tipo de ataque correctos.
            Move move = new Move("Test Move", movePwr, PokemonType.Bug, moveType);

            // ACT
            int actualDmg = DamageCalculator.Calculate(attacker, defender, move, mod);

            // ASSERT
            // NUnit comparará el valor de retorno con el 'ExpectedResult' del TestCase.
            return actualDmg;
        }
    }
}