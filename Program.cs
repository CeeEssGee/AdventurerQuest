using System;
using System.Collections.Generic;

// Every class in the program is defined within the "Quest" namespace
// Classes within the same namespace refer to one another without a "using" statement
namespace Quest
{
    class Program
    {

        // Add code to record the number of successful challenges the adventurer completes during a quest. If the user chooses to repeat the quest, multiply this number by 10 and add it do the initial Awesomeness of the adventurer on their next quest.
        static int RunCounter = 0;
        static void Main(string[] args)
        {


            NewGame();

            // wrapped my game code in a method called NewGame and moved it outside of Main, added a question at the end, added a Console.ReadLine and an if statement

            static void NewGame()
            {
                // prompt the user to enter their name
                Console.WriteLine("What is your name?");
                // stores the user's name in a variable
                string playerName = Console.ReadLine();
                // In Program.cs create a new instance of the Robe class and set its properties.
                Robe GreenRobe = new Robe()
                {
                    Colors = new List<string>
                {
                    "green",
                    "purple"
                },
                    Length = 60
                };

                // Update the Program.cs file to create a Hat and pass it to the Adventurer's constructor.
                Hat ExtremelyShinyHat = new Hat();
                ExtremelyShinyHat.ShininessLevel = 15;

                // In Program.cs create an instance of the Prize.
                Prize RubberDuck = new Prize("A Rubber Duck!");

                // Create a few challenges for our Adventurer's quest
                // The "Challenge" Constructor takes three arguments
                //   the text of the challenge
                //   a correct answer
                //   a number of awesome points to gain or lose depending on the success of the challenge
                Challenge twoPlusTwo = new Challenge("2 + 2?", 4, 10);
                Challenge theAnswer = new Challenge(
                    "What's the answer to life, the universe and everything?", 42, 25);
                Challenge whatSecond = new Challenge(
                    "What is the current second?", DateTime.Now.Second, 50);

                int randomNumber = new Random().Next() % 10;
                Challenge guessRandom = new Challenge("What number am I thinking of?", randomNumber, 25);

                Challenge favoriteBeatle = new Challenge(
                    @"Who's your favorite Beatle?
                1) John
                2) Paul
                3) George
                4) Ringo
                ",
                    4, 20
                );
                // Let's make the challenges a little more interesting. Add 2 to 5 more challenges to the program
                Challenge favoriteColor = new Challenge(
                    @"What's Courtney's favorite color?
                1) Red
                2) Green
                3) Blue
                4) Purple
                ",
                    4, 25
                );
                Challenge phobia = new Challenge(
                    @"What is cynophobia?
                1) Fear of sin
                2) Fear of blue
                3) Fear of dogs
                4) Fear of clothes
                ",
                    3, 25
                );
                Challenge languages = new Challenge("How many languages are written from right to left?", 12, 50);
                Challenge factOrCrap1 = new Challenge(
                    @"Twins can have different fathers.
                1) Fact
                2) Crap
                ",
                    1, 10
                );
                Challenge factOrCrap2 = new Challenge(
                    @"A cup of tea has more caffeine than a cup of coffee.
                1) Fact
                2) Crap
                ",
                    2, 10
                );




                // "Awesomeness" is like our Adventurer's current "score"
                // A higher Awesomeness is better

                // Here we set some reasonable min and max values.
                //  If an Adventurer has an Awesomeness greater than the max, they are truly awesome
                //  If an Adventurer has an Awesomeness less than the min, they are terrible
                int minAwesomeness = 0;
                int maxAwesomeness = 100;

                // Make a new "Adventurer" object using the "Adventurer" class
                // the user's name variable into the Adventurer constructor when creating the Adventurer object
                // Update the Program.cs file to create a Hat and pass it to the Adventurer's constructor.
                Adventurer theAdventurer = new Adventurer(playerName, GreenRobe, ExtremelyShinyHat);


                // Add code to record the number of successful challenges the adventurer completes during a quest. If the user chooses to repeat the quest, multiply this number by 10 and add it do the initial Awesomeness of the adventurer on their next quest.
                theAdventurer.Awesomeness += (RunCounter * 10);
                Console.WriteLine($"You have {theAdventurer.Awesomeness} Awesomeness Points.");

                // Before the adventurer starts their challenge, call the GetDescription method and print the results to the console.
                theAdventurer.GetDescription();
                // A list of challenges for the Adventurer to complete
                // Note we can use the List class here because have the line "using System.Collections.Generic;" at the top of the file.
                List<Challenge> challenges = new List<Challenge>()
            {
                twoPlusTwo,
                theAnswer,
                whatSecond,
                guessRandom,
                favoriteBeatle,
                favoriteColor,
                phobia,
                languages,
                factOrCrap1,
                factOrCrap2
            };

                // Loop through all the challenges and subject the Adventurer to them
                // foreach (Challenge challenge in challenges)
                // randomly select 5 challenges for our adventurer to face.
                List<int> indices = new List<int>();
                Random random = new Random();
                int length = challenges.Count - 1;
                while (indices.Count < 5)
                {
                    int candidate = random.Next(0, length);
                    if (!indices.Contains(candidate))
                    {
                        indices.Add(candidate);
                    }
                }

                foreach (int index in indices)
                {
                    challenges[index].RunChallenge(theAdventurer);
                }


                // This code examines how Awesome the Adventurer is after completing the challenges
                // And praises or humiliates them accordingly
                if (theAdventurer.Awesomeness >= maxAwesomeness)
                {
                    Console.WriteLine("YOU DID IT! You are truly awesome!");
                }
                else if (theAdventurer.Awesomeness <= minAwesomeness)
                {
                    Console.WriteLine("Get out of my sight. Your lack of awesomeness offends me!");
                }
                else
                {
                    Console.WriteLine("I guess you did...ok? ...sorta. Still, you should get out of my sight.");
                }
                // At the end of the quest (before you ask if the user wants to repeat the quest) call the ShowPrize method.
                RubberDuck.ShowPrize(theAdventurer);
                // at the end of the game, the user is asked if they want to play again
                Console.WriteLine("Do you want to play again? (y/n)");
                // stores the response in a variable
                string playAgain = Console.ReadLine();
                // if the variable is y or Y, the game reloads, if it is anything else, the game stops
                if (playAgain == "y" || playAgain == "Y")
                {
                    RunCounter += 1;
                    NewGame();
                }
            }
        }



    }

}
