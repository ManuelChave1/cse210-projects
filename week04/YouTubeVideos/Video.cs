using System;
using System.Collections.Generic;


    class Video
    {
		private string _title;
		private string _author;
		private int _length;
		//List<Comment> _comment = new List<Comment>();

		public List<Comment> _comment;

		public Video(string title, string author, int length)
		{
			_title = title;
			_author = author;
			_length = length;
		}

		public string GetTitle()
        {
			return _title;
        }
		public string GetAuthor()
		{
			return _author;
		}
		public int GetLength()
		{
			return _length;
		}



		//public void AddComment(Comment com)
       // {
		//	_comment.Add(com);
        //}
		public int GetNumComments()
		{
			return _comment.Count;
		}

		public void DisplayInf()
        {
			//Console.WriteLine($"{_title}-{_author}- {_length} seconds \nComments:");

			foreach(Comment comment in _comment)
            {
				Console.WriteLine($"{comment.GetName()}\n{comment.GetText()}\n");
            }
        }


	}

