using System;

namespace ScriptureMemorizer
{
    public class Word
    {
        private string _text;
        private bool _isHidden;

        // Constructor accepts the word text and initializes it as visible.
        public Word(string text)
        {
            _text = text;
            _isHidden = false;
        }

        // Hides the word.
        public void Hide()
        {
            _isHidden = true;
        }

        // Makes the word visible (not used in this program, but provided for completeness).
        public void Show()
        {
            _isHidden = false;
        }

        // Returns whether the word is hidden.
        public bool IsHidden()
        {
            return _isHidden;
        }

        // Returns the word for display: either the text or underscores if hidden.
        public string GetDisplayText()
        {
            if (_isHidden)
            {
                // Replace each character with an underscore.
                return new string('_', _text.Length);
            }
            else
            {
                return _text;
            }
        }
    }
}
