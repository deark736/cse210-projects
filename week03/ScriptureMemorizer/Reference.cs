using System;

namespace ScriptureMemorizer
{
    public class Reference
    {
        private string _book;
        private int _chapter;
        private int _verse;
        private int _endVerse;

        // Constructor for a single verse reference.
        public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _endVerse = 0;  // 0 indicates no end verse.
        }

        // Constructor for a verse range (e.g., Proverbs 3:5-6).
        public Reference(string book, int chapter, int verse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _endVerse = endVerse;
        }

        // Returns the reference text (e.g., "John 3:16" or "Proverbs 3:5-6").
        public string GetDisplayText()
        {
            if (_endVerse > 0 && _endVerse != _verse)
            {
                return $"{_book} {_chapter}:{_verse}-{_endVerse}";
            }
            else
            {
                return $"{_book} {_chapter}:{_verse}";
            }
        }
    }
}
