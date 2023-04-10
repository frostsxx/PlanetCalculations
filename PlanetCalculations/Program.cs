using System;

namespace PlanetCalculations
{
    class Program
    {
        static void Main(string[] args)
        {

            // Choose a planet
            Console.WriteLine("Choose a planet number (1 - Mercury / 2 - Venus / 3 - Earth / 4 - Mars / 5 - Jupiter / 6 - Saturn / 7 - Uranus / 8 - Neptune): ");
            var planet = int.Parse(Console.ReadLine());

            while (planet < 1 || planet > 8)
            {
                Console.WriteLine("Error: Invalid planet number.\n");
                // Re-enter planet number
                Console.Write("Enter a valid planet number: ");
                planet = int.Parse(Console.ReadLine());
            }


            // Your Age
            Console.WriteLine("How old are you?");
            int userAge = int.Parse(Console.ReadLine());


            // Length of years of planets (in Earth years)
            double mercuryYears = 0.2;
            double venusYears = 0.6;
            double marsYears = 1.9;
            double jupiterYears = 11.9;
            double saturnYears = 29.4;
            double uranusYears = 84.0;
            double neptuneYears = 165.0;


            // Age on planets
            double mercuryAge = userAge / mercuryYears;
            double venusAge = userAge / venusYears;
            double marsAge = userAge / marsYears;
            double jupiterAge = userAge / jupiterYears;
            double saturnAge = userAge / saturnYears;
            double uranusAge = userAge / uranusYears;
            double neptuneAge = userAge / neptuneYears;


            // Time to planets
            double journeyToMercury = 3.449692;
            double journeyToVenus = 0.4188912;
            double journeyToMars = 0.4435319;
            double journeyToJupiter = 6.142466;
            double journeyToSaturn = 6.598221;
            double journeyToUranus = 9.598905;
            double journeyToNeptune = 11.99726;


            // New Age on Earth
            double newEarthAgeMercury = userAge + journeyToMercury;
            double newEarthAgeVenus = userAge + journeyToVenus;
            double newEarthAgeMars = userAge + journeyToMars;
            double newEarthAgeJupiter = userAge + journeyToJupiter;
            double newEarthAgeSaturn = userAge + journeyToSaturn;
            double newEarthAgeUranus = userAge + journeyToUranus;
            double newEarthAgeNeptune = userAge + journeyToNeptune;


            // New Age on planets
            double newMercuryAge = newEarthAgeJupiter / mercuryYears;
            double newVenusAge = newEarthAgeJupiter / venusYears;
            double newMarsAge = newEarthAgeJupiter / marsYears;
            double newJupiterAge = newEarthAgeJupiter / jupiterYears;
            double newSaturnAge = newEarthAgeJupiter / saturnYears;
            double newUranusAge = newEarthAgeJupiter / uranusYears;
            double newNeptuneAge = newEarthAgeJupiter / neptuneYears;


            // Log calculations to console
            if (planet == 1)
            {
                Console.WriteLine("Your age on Earth is: " + userAge + " years old.");
                Console.WriteLine("Your age on Mercury is: " + mercuryAge + " years old.\n");
                Console.WriteLine("If you were to fly to Mercury... \n ");
                Console.WriteLine("Your new age on Earth would be: " + newEarthAgeMercury + " years old.");
                Console.WriteLine("Your new age on Mercury would be: " + newMercuryAge + " years old.");
            }

            else if (planet == 2)
            {
                Console.WriteLine("Your age on Earth is: " + userAge + " years old.");
                Console.WriteLine("Your age on Venus is: " + venusAge + " years old.\n");
                Console.WriteLine("If you were to fly to Venus... \n ");
                Console.WriteLine("Your new age on Earth would be: " + newEarthAgeVenus + " years old.");
                Console.WriteLine("Your new age on Venus would be: " + newVenusAge + " years old.");
            }

            else if (planet == 3)
            {
                Console.WriteLine("Your age on Earth would be: " + userAge + " years old.");
            }

            else if (planet == 4)
            {
                Console.WriteLine("Your age on Earth is: " + userAge + " years old.");
                Console.WriteLine("Your age on Mars is: " + marsAge + " years old.\n");
                Console.WriteLine("If you were to fly to Mars... \n ");
                Console.WriteLine("Your new age on Earth would be: " + newEarthAgeMars + " years old.");
                Console.WriteLine("Your new age on Mars would be: " + newMarsAge + " years old.");
            }

            else if (planet == 5)
            {
                Console.WriteLine("Your age on Earth is: " + userAge + " years old.");
                Console.WriteLine("Your age on Jupiter is: " + jupiterAge + " years old.\n");
                Console.WriteLine("If you were to fly to Jupiter... \n ");
                Console.WriteLine("Your new age on Earth would be: " + newEarthAgeJupiter + " years old.");
                Console.WriteLine("Your new age on Jupiter would be: " + newJupiterAge + " years old.");
            }

            else if (planet == 6)
            {
                Console.WriteLine("Your age on Earth is: " + userAge + " years old.");
                Console.WriteLine("Your age on Saturn is: " + saturnAge + " years old.\n");
                Console.WriteLine("If you were to fly to Saturn... \n ");
                Console.WriteLine("Your new age on Earth would be: " + newEarthAgeSaturn + " years old.");
                Console.WriteLine("Your new age on Saturn would be: " + newSaturnAge + " years old.");
            }

            else if (planet == 7)
            {
                Console.WriteLine("Your age on Earth is: " + userAge + " years old.");
                Console.WriteLine("Your age on Uranus is: " + uranusAge + " years old.\n");
                Console.WriteLine("If you were to fly to Uranus... \n ");
                Console.WriteLine("Your new age on Earth would be: " + newEarthAgeUranus + " years old.");
                Console.WriteLine("Your new age on Uranus would be: " + newUranusAge + " years old.");
            }

            else if (planet == 8)
            {
                Console.WriteLine("Your age on Earth is: " + userAge + " years old.");
                Console.WriteLine("Your age on Neptune is: " + neptuneAge + " years old.\n");
                Console.WriteLine("If you were to fly to Neptune... \n ");
                Console.WriteLine("Your new age on Earth would be: " + newEarthAgeNeptune + " years old.");
                Console.WriteLine("Your new age on Neptune would be: " + newNeptuneAge + " years old.");
            }

            Console.ReadLine();
        }
    }
}
