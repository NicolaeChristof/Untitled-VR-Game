using System;
using System.Collections.Generic;
using UnityEngine;

namespace Samples
{
    /// <summary>
    /// If needed, include a summary of your class here in this nicely formatted XML docstring comment. This should be
    /// used for classes that are complex in nature or major core systems that actually need documentation.
    /// </summary>
    public class ExampleMonobehaviour : MonoBehaviour
    {
        // serialized fields
        [SerializeField]
        private int listCapacity = default;
        
        // properties
        public int NumberOfWords => words.Count;
        
        // member variables
        private List<string> words;
        
        // unity functions
        private void Awake()
        {
            words = new List<string>();
        }
        private void Start()
        {
            Debug.Log("I've started!");
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
