using System;

namespace PlanetCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Will be stored the planet number and user age
            int planet;
            int userAge;

            // Choose a planet
            Console.Write("Choose a planet number (1 - Mercury / 2 - Venus / 3 - Earth / 4 - Mars / 5 - Jupiter / 6 - Saturn / 7 - Uranus / 8 - Neptune): ");

            while (!int.TryParse(Console.ReadLine(), out planet))
            {
                Console.Write("You are only allowed to use numbers, please enter again: ");
            }

            while (planet < 1 || planet > 8)
            {
                Console.WriteLine("Error: Invalid planet number.\n");
                // Re-enter planet number
                Console.Write("Enter a valid planet number: ");
                planet = int.Parse(Console.ReadLine());
            }


            // Your Age
            Console.Write("How old are you? ");

            while (!int.TryParse(Console.ReadLine(), out userAge))
            {
                Console.Write("You are only allowed to use numbers, please enter again: ");
            }


            // Length of years of planets (in Earth years)
            double[] planetYears = { 0.2, 0.6, 1.0, 1.9, 11.9, 29.4, 84.0, 165.0 };

            /*
            mercuryYears = 0.2;
            venusYears = 0.6;
            earthYears = 1.0;
            marsYears = 1.9;
            jupiterYears = 11.9;
            saturnYears = 29.4;
            uranusYears = 84.0;
            neptuneYears = 165.0;
            */


            // Age on planets
            double[] planetAge = new double[8];
            for (int index = 0; index < planetAge.Length; index++)
            {
                planetAge[index] = userAge / planetYears[index];
            }

            // Time to planets
            double[] journeyTimes = { 3.449692, 0.4188912, 0.0, 0.4435319, 6.142466, 6.598221, 9.598905, 11.99726 };

            /*
            journeyToMercury = 3.449692;
            journeyToVenus = 0.4188912;
            journeyToEarth = 0.0;
            journeyToMars = 0.4435319;
            journeyToJupiter = 6.142466;
            journeyToSaturn = 6.598221;
            journeyToUranus = 9.598905;
            journeyToNeptune = 11.99726;
            */


            // New Age on Earth
            double[] newEarthAge = new double[8];
            for (int index = 0; index < newEarthAge.Length; index++)
            {
                newEarthAge[index] = userAge + journeyTimes[index];
            }

            // New Age on planets
            double[] newPlanetAge = new double[8];
            for (int index = 0; index < newPlanetAge.Length; index++)
            {
                newPlanetAge[index] = newEarthAge[index] / planetYears[index];
            }

            // Define planet names
            string[] planetNames = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

            if (planet == 3)
            {
                Console.WriteLine($"Dummy you have {userAge} years old! :P");
            }
            else if (planet >= 1 && planet <= 8)
            {
                /*
                 * The index position for the planetAge, newEarthAge, 
                 * and newPlanetAge arrays should be planet-2 instead of planet-1, 
                 * since the planet variable is 1-based and the arrays are 0-based.
                 */
                Console.WriteLine($"Your age on Earth is: {userAge} years old.");
                Console.WriteLine($"Your age on {planetNames[planet - 1]} is: {planetAge[planet - 1]} years old.\n");
                Console.WriteLine($"If you were to fly to {planetNames[planet - 1]}... \n ");
                Console.WriteLine($"Your new age on Earth would be: {newEarthAge[planet - 1]} years old.");
                Console.WriteLine($"Your new age on {planetNames[planet - 1]} would be: {newPlanetAge[planet - 1]} years old.");
            }

            Console.ReadLine();

        }

    }
}

