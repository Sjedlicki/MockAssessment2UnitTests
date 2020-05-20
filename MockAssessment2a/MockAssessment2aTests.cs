using System;
using System.Collections.Generic;
using Xunit;

namespace MockAssessment2a
{
    public class MockAssessment2aTests
    {
        [Fact]
        public static void AddToArray()
        {
            string[] expected = { "Yoda", "Darth", "Luke" };
            string[] actual = Challenge.AddStarWarsCharacters("Yoda", "Darth", "Luke");


            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void TestOfStrength()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("Yoda", 4500000);
            dictionary.Add("Darth", 60200);
            dictionary.Add("Luke", 3000);

            string expected = "Yoda".ToLower();

            string actual = Challenge.DeathStarCombat(dictionary).ToLower();

            Assert.Equal(expected, actual);
        }

        [Fact]

        public static void RemoveFromList()
        {
            List<string> planets = new List<string> { "Tatooine", "Alderaan", "Hoth"};
            List<string> expected = new List<string> { "Tatooine","Alderaan"};
            List<string> actuals = Challenge.CheckPlanets(planets, "Hoth");

            planets.ForEach(planet => planet.ToLower());
            expected.ForEach(expect => expect.ToLower());
            actuals.ForEach(actual => actual.ToLower());

            Assert.Equal(expected, actuals);
        }

        [Fact]
        public static void AddToList()
        {
            List<string> planets = new List<string> { "Tatooine", "Alderaan" };
            List<string> expected = new List<string> { "Tatooine", "Alderaan", "Hoth" };
            List<string> actuals = Challenge.CheckPlanets(planets, "Hoth");

            planets.ForEach(planet => planet.ToLower());
            expected.ForEach(expect => expect.ToLower());
            actuals.ForEach(actual => actual.ToLower());


            Assert.Equal(expected, actuals);
        }
        [Fact]
        public static void VaderWasCaptured()
        {
            string expected = "Vader Was Captured!".ToLower();
            string actual = Challenge.TryToCatchDarthVader("1").ToLower();            

            Assert.Contains(expected, actual);
        }

        [Fact]
        public static void VaderGotAway()
        {
            string expected = "Vader Got Away".ToLower();
            string actual = Challenge.TryToCatchDarthVader("Vader Haters").ToLower();           

            Assert.Contains(expected, actual);
        }
    }
}