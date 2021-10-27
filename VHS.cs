using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab
{
    class VHS : Movie
    {
        public VHS(string Title, Genre Category, int Runtime, params string[] Scenes) : base(Title, Category, Runtime, Scenes) { }
     
        public int CurrentTime { get; set; } = 0;
        public override void Play()
        {
            int sceneDivide = Runtime / Scenes.Count;
            
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"{CurrentTime} mins: {Scenes[i]}\n");
                CurrentTime += sceneDivide;
            }
            Rewind();

        }
        public void Rewind()
        {
            
            Console.WriteLine("Be Kind - REWIND!");
            bool rewind = ContinueLoop("Would you like to rewind this tape?");
            if (rewind == true)
            {
                CurrentTime = 0;
                Console.WriteLine("This tape is rewinding.  Current time reset to 0.");
            }
            
            
        }
        public static bool ContinueLoop(string question)
        {
            string response = GetInput(question);
            if (response.ToLower() == "y")
            {
                return true;
            }
            else if (response.ToLower() == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input.  Please input \"y\" or \"n\".\n");
                return ContinueLoop(question);
            }
        }
        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string output = Console.ReadLine();
            return output;
        }
    }
    
}
