using System;
using System.Collections.Generic;



    class Comment
    {
        private string _name;
        private string _text;

        public Comment(string name, string text)
        {
            _name = name;
            _text = text;
        }

        public Comment()
        {

        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                Console.Write("Enter a name");
                return;
            }

            _name = name; 
        }

        public string GetText()
        {
            return _text;
        }

        public void SetText(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                Console.Write("Enter a comment");
                return;
            }

            _text = text;
        }
    }

