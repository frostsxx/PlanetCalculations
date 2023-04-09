Did you know that your age would be different on another planet? Different planets orbit the sun at different rates, so 1 year on earth can be much shorter or much longer on another planet, depending on their position in the solar system.

We're going to write an equation that calculates your age on solar system planets.
To calculate a person’s age on another planet, we need to know [how long it takes each planet to orbit the Sun](https://www.mentalfloss.com/posts/solar-system-planets-days-year-length) (relative to a year on Earth):

Next we’ll write the calculations. The formula for calculating an age on another planet is: divide the user age in Earth years by the length of the other planet’s year (in Earth years) to get your age in that planet’s years. EX: (jupiterAge = userAge / jupiterYears;)

If we were to fly to Jupiter for example, [it could take as long as 2,242 (Earth) days or about 6.142466 years!](https://www.universetoday.com/128259/long-take-get-jupiter/)

When you reach Jupiter you will have two questions:

* What would be your new age in Earth years?
* What would be your new age in Jupiter years?

To answer the first one we can find our new age on Earth by adding the time it took to get to Jupiter to our current age. EX: (newEarthAgeJupiter = userAge + journeyToJupiter;)

And to answer the last one we can find our new age on Jupiter by following the same formula we used earlier, but substituting our new earth age. EX: (newJupiterAge = newEarthAgeJupiter / jupiterYears;)
