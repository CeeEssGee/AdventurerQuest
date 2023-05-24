namespace Quest
{
    // Create a new class called Hat in its own file.
    public class Hat
    {

        // Add a mutable integer property called ShininessLevel to indicate how shiny the hat is.
        public int ShininessLevel { get; set; }

        // Add a computed string property called ShininessDescription to return a text description of the hat's shininess according to the following rules.
        public string ShininessDescription
        {
            get
            {

                if (ShininessLevel < 2)
                {
                    return "dull";
                }
                else if (ShininessLevel >= 2 && ShininessLevel <= 5)
                {
                    return "noticeable";
                }
                else if (ShininessLevel >= 6 && ShininessLevel <= 9)
                {
                    return "bright";
                }
                else
                {
                    return "blinding";
                }

            }

        }
    }

}