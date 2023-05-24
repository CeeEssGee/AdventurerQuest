using System;

namespace Quest
{

    // Create a new class called Prize.
    public class Prize
    {
        // Create a private field in the class called _text to contain a textual description of the prize.
        private string _text { get; set; }

        // Create a constructor in the class that takes a text parameter and uses it to set the _text field.
        public Prize(string Text)
        {
            _text = Text;
        }

        // Create a method in the class called ShowPrize.
        // The method should accept an Adventurer as a parameter.
        // If the adventurer's Awesomeness is greater than zero, write the _text field to the console the same number of times as the value of the Awesomeness property.
        // If the adventurer's Awesomeness is zero or less than zero, write a message of pity to the console.
        public void ShowPrize(Adventurer theAdventurer)
        {
            int awesomePoints = theAdventurer.Awesomeness;
            if (awesomePoints > 0)
            {
                while (awesomePoints > 0)
                {
                    Console.Write("You win a ");
                    Console.WriteLine(_text);
                    awesomePoints--;
                }
            }
            else
            {
                Console.WriteLine("No prize for you!");
            }
        }

    }



}