using System;

namespace DailyScripture
{      
    class Word
    {
        private string _text;
        private bool _isHidden;

        public Word(string text)
        {
            this._text = text;
            _isHidden = false;
        }

        public string GetText()
        {
            return _text;
        }

        public bool IsHidden()
        {
            return _isHidden;
        }
        public void Hide()
        {
            _isHidden = true;
        }

    }
}