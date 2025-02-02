using System;

namespace ScriptureMemorizer
{
    /*
     * Scripture Memorizer Program
     * 
     * This implementation exceeds the basic requirements by incorporating a stretch challenge:
     * Instead of randomly selecting any word (even if it is already hidden) when hiding words,
     * the program now randomly selects only from those words that are still visible.
     * 
     * By filtering out already hidden words, each iteration of hiding reveals only new words being
     * replaced by underscores. This provides a more effective and user-friendly approach to memorization.
     * 
     * Additionally, the program adheres to the principles of encapsulation and object-oriented design
     * by separating responsibilities among the Scripture, Reference, and Word classes.
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Create a Reference object for John 3:16.
            Reference reference = new Reference("John", 3, 16);

            // Use the provided version of the verse for John 3:16.
            string scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
            
            // Create a Scripture object with the reference and text.
            Scripture scripture = new Scripture(reference, scriptureText);

            // Main loop: display scripture and hide more words until all are hidden or the user quits.
            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());

                // End the program if all words are hidden.
                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine("\nAll words have been hidden. Press any key to exit.");
                    Console.ReadKey();
                    break;
                }

                Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
                string input = Console.ReadLine();
                if (input.Trim().ToLower() == "quit")
                {
                    break;
                }

                // Hide a few random words; for example, hide 3 words at a time.
                scripture.HideRandomWords(3);
            }
        }
    }
}
