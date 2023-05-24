namespace Quest
{
    // An instance of the Adventurer class is an object that will undergo some challenges
    public class Adventurer
    {
        // This is an "immutable" property. It only has a "get".
        // The only place the Name can be set is in the Adventurer constructor
        // Note: the constructor is defined below.
        public string Name { get; }

        // This is a mutable property it has a "get" and a "set"
        //  So it can be read and changed by any code in the application
        public int Awesomeness { get; set; }

        // Add a new immutable property to the Adventurer class called ColorfulRobe. The type of this property should be Robe.
        public Robe ColorfulRobe { get; }

        // A constructor to make a new Adventurer object with a given name
        public Adventurer(string name, Robe colorfulRobe)
        {
            Name = name;
            Awesomeness = 50;
            // Add a new constructor parameter to the Adventurer class to accept a Robe and to set the ColorfulRobe property.
            // Pass the new Robe into the constructor of the Adventurer.
            ColorfulRobe = colorfulRobe;
        }

        // This method returns a string that describes the Adventurer's status
        // Note one way to describe what this method does is:
        //   it transforms the Awesomeness integer into a status string
        public string GetAdventurerStatus()
        {
            string status = "okay";
            if (Awesomeness >= 75)
            {
                status = "great";
            }
            else if (Awesomeness < 25 && Awesomeness >= 10)
            {
                status = "not so good";
            }
            else if (Awesomeness < 10 && Awesomeness > 0)
            {
                status = "barely hanging on";
            }
            else if (Awesomeness <= 0)
            {
                status = "not gonna make it";
            }

            return $"Adventurer, {Name}, is {status}";
        }

        // Add a new method to the Adventurer class called GetDescription. This method should return a string that contains the adventurer's name and a description of their robe. Defined in Adventurer, so it knows it's defined on an Adventurer and is assumed that "this" is the adventurer (or we could pass a parameter "Adventurer theAdventurer" and replace this with theAdventurer - etc.)
        public void GetDescription()
        {
            string colorList = "";
            foreach (string color in this.ColorfulRobe.Colors)
            {
                colorList += color + " ";
            }
            System.Console.WriteLine($"Adventurer, {this.Name}, is wearing an amazing {colorList}robe that is {this.ColorfulRobe.Length} inches long.");
        }
    }
}