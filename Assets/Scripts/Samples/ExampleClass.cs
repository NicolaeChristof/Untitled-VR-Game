using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Samples
{
    /// <summary>
    /// If needed, include a summary of your class here in this nicely formatted XML docstring comment. This should be
    /// used for classes that are complex in nature or major core systems that actually need documentation.
    /// </summary>
    public class ExampleClass
    {
        // member variables
        private readonly List<string> words;

        // properties
        public int NumberOfWords => words.Count;
        
        // constructors
        public ExampleClass()
        {
            this.words = new List<string>();
        }
        /// <summary>
        /// If needed, include a summary of your function here in this nicely formatted XML docstring comment.
        /// </summary>
        /// <param name="words"></param>
        public ExampleClass(params string[] words)
        {
            this.words = words.ToList();
        }
        
        // public functions
        public void PrintWords()
        {
            foreach (var word in words)
            {
                Debug.Log(word);
            }
        }
        
        // private functions
        private void ReverseAllWords()
        {
            for (var i = 0; i < words.Count; i++)
            {
                var word = words[i];
                var charArray = word.ToCharArray();
                Array.Reverse( charArray );
                words[i] = new string(charArray);
            }
        }
    }
}