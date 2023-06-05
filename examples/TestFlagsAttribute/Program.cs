namespace TestFlagsAttribute
{
    internal class Program
    {
        // Define an Enum without FlagsAttribute.
        enum SingleHue : short
        {
            None = 0,
            Black = 1,
            Red = 2,
            Green = 4,
            Blue = 8
        };

        // Define an Enum with FlagsAttribute.
        [Flags]
        enum MultiHue : short
        {
            None = 0,
            Black = 1,
            Red = 2,
            Green = 4,
            Blue = 8
        };

        static void Main(string[] args)
        {
            // G or g
            // Displays the enumeration entry as a string value, if possible,
            // and otherwise displays the integer value of the current instance.
            // If the enumeration is defined with the Flags attribute set, the
            // string values of each valid entry are concatenated together,
            // separated by commas.If the Flags attribute is not set, an invalid
            // value is displayed as a numeric entry. 

            // Display all possible combinations of values.
            Console.WriteLine(
                 "All possible combinations of values without FlagsAttribute:");
            for (int val = 0; val <= 16; val++)
                Console.WriteLine("{0,3} - {1:G}", val, (SingleHue)val);

            // Display all combinations of values, and invalid values.
            Console.WriteLine(
                 "\nAll possible combinations of values with FlagsAttribute:");
            for (int val = 0; val <= 16; val++)
                Console.WriteLine("{0,3} - {1:G}", val, (MultiHue)val);
        }
    }
}