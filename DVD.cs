using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab
{
    class DVD : Movie
    {
        public DVD(string Title, Genre Category, int Runtime, params string[] Scenes) : base(Title, Category, Runtime, Scenes)
        { }
        public override void Play()
        {
            Blockbuster bb = new Blockbuster();

            Console.WriteLine($"Scene selection for {Title}:\n");
            bb.PrintScenes(Scenes);
            bool playDVD = true;
            while (playDVD)
            {
                try
                {
                    int userSelect = int.Parse(Console.ReadLine());
                    
                        if (userSelect > 0 && userSelect < Scenes.Count)
                        {
                            int currentTime = (Runtime / Scenes.Count) * (userSelect - 1);
                            Console.WriteLine($"Playing {Title} from scene {userSelect}: {Scenes[userSelect]}.  Runtime starting at {currentTime} mins\n");

                            for (int i = userSelect; i < Scenes.Count; i++)
                            {
                                Console.WriteLine($"{currentTime} mins: {Scenes[i]}\n");
                                currentTime += Runtime / Scenes.Count;
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"That is not a valid scene for {Title}.  Please select a scene between 1 and {Scenes.Count}.");
                            continue;
                        }
                }
                catch (Exception)
                {
                    Console.WriteLine($"Please input a number from 1 to {Scenes.Count} to continue");
                    continue;
                }
            }
        }
    }
}
