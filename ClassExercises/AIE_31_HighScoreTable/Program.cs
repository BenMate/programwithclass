using System;
using System.Collections.Generic;
using System.IO;

namespace AIE_31_HighScoreTable
{

    class ScoreEntry
    {
        public string name;
        public int score;

        public ScoreEntry()
        {
        }

        public ScoreEntry(string name, int score)
        {
            this.name = name;
            this.score = score;
        }


        class Program
        {

            static void Main(string[] args)
            {

                List<ScoreEntry> scores = new List<ScoreEntry>()
            {
                new ScoreEntry("bob",12),
                new ScoreEntry("fred",20),
                new ScoreEntry("ted",6),
                new ScoreEntry("tom",42),
                new ScoreEntry("harry",9),

            };

                //save the scores
                SerialiseScores("highscores.txt", scores);

                //clear the scores
                scores = new List<ScoreEntry>();

                //Read the scores
                DeSerialiseScoreos("highscore.txt", scores);

                //print the scores
                foreach (var entry in scores)
                {
                    Console.WriteLine($"{entry.name} : {entry.score}");
                }

                static void SerialiseScores(string filename, List<ScoreEntry> scores)
                {
                    //TODO: write core to write the scores to the file

                    using (StreamWriter sw = File.CreateText(filename))
                    {
                        foreach (var entry in scores)
                        {
                            if (!string.IsNullOrWhiteSpace(entry.name)) sw.WriteLine("name: " + entry.name);
                            if (!string.IsNullOrWhiteSpace(entry.score)) sw.WriteLine("score: " + entry.score);
                            sw.WriteLine("");

                        }
                    }
                }

                static void DeSerialiseScoreos(string filename, List<ScoreEntry> scores)
                {


                    //creates the file if the file isnt there.
                    var fileInfo = new FileInfo(filename);
                    var dir = fileInfo.Directory.FullName;
                    Directory.CreateDirectory(dir);


                    ScoreEntry scores = new ScoreEntry();

                    //TODO: write code to read the scores from the file
                    using (StreamReader sr = File.OpenText(filename))
                    {

                        string s;
                        while ((s = sr.ReadLine()) != null)
                        {

                            if (string.IsNullOrEmpty(s))
                            {
                                scores.Add(entry);

                                entry = new ScoreEntry();
                            }

                            else
                            {
                                var entry = s.Split(" ");

                                if (entry[0] == "name:") scores.name = entry[1];
                                if (entry[0] == "score:") scores.number = entry[1];


                                // Console.WriteLine(entry[1]);
                            }
                        }

                    }
                }
            }
        }
    }
}
