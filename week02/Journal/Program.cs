// Enhancements:
// 1. Added mood tracking to each journal entry. Users can record their mood
//    (e.g., Happy, Sad, Excited) alongside their response.
// 2. Modified Entry class to include the _mood attribute.
// 3. Updated AddEntry and Display methods to handle mood tracking.
// 4. Enhanced SaveToFile and LoadFromFile to save and load the mood attribute.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    Console.Write("Your mood (e.g., Happy, Sad, Excited): ");
                    string mood = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();
                    journal.AddEntry(new Entry(date, prompt, response, mood));
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save to: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter filename to load from: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
