using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        // Constructor: accepts a Reference object and a full scripture text.
        // The text is split into words and each word is encapsulated in a Word object.
        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();

            // Split the scripture text on spaces.
            string[] parts = text.Split(' ');
            foreach (string part in parts)
            {
                _words.Add(new Word(part));
            }
        }

        // Hides a specified number of random words that are currently visible.
        public void HideRandomWords(int numberToHide)
        {
            Random random = new Random();
            int totalWords = _words.Count;

            // Create a list of indices for words that are still visible.
            List<int> visibleIndices = new List<int>();
            for (int i = 0; i < totalWords; i++)
            {
                if (!_words[i].IsHidden())
                {
                    visibleIndices.Add(i);
                }
            }

            // Determine how many words to hide in this iteration.
            int wordsToHide = Math.Min(numberToHide, visibleIndices.Count);

            // Randomly hide the selected number of visible words.
            for (int i = 0; i < wordsToHide; i++)
            {
                int randomIndex = random.Next(visibleIndices.Count);
                int wordIndex = visibleIndices[randomIndex];
                _words[wordIndex].Hide();
                visibleIndices.RemoveAt(randomIndex);
            }
        }

        // Returns the complete display text including the reference and the scripture text with hidden words.
        public string GetDisplayText()
        {
            string displayText = _reference.GetDisplayText() + "\n";
            foreach (Word word in _words)
            {
                displayText += word.GetDisplayText() + " ";
            }
            return displayText.TrimEnd();
        }

        // Checks if every word in the scripture is hidden.
        public bool IsCompletelyHidden()
        {
            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
