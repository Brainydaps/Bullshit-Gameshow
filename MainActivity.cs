using Bullshit_Gameshow;

namespace Bullshit_Gameshow
{
    
    using System;
    using System.Collections.Generic;

    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }
    }

    public class Question
    {
        public string Text { get; set; }
        public List<string> Options { get; set; }
        public int Answer { get; set; }

        public Question(string text, List<string> options, int answer)
        {
            Text = text;
            Options = options;
            Answer = answer;
        }
    }

    public class Contender
    {
        public string Name { get; set; }
        public double Gullibility { get; set; }

        public Contender(string name, double gullibility)
        {
            Name = name;
            Gullibility = gullibility;
        }
    }

    public class BullshitGame
    {
        public static void Main(string[] args)
        {
            // Initialize players, questions, and contenders
            Console.Write("Enter your name: ");
            string playerName = Console.ReadLine();
            Player player = new Player(playerName);

            List<Question> questions = new List<Question>()
        {
            new Question("What is the capital of France?", new List<string>() {"London", "Paris", "Berlin", "Rome"}, 1),
            new Question("What is the largest planet in our solar system?", new List<string>() {"Earth", "Jupiter", "Mars", "Venus"}, 1),
            new Question("What is the tallest mountain in the world?", new List<string>() {"Mount Everest", "K2", "Kangchenjunga", "Lhotse"}, 0),
            new Question("What is the longest river in the world?", new List<string>() {"Nile", "Amazon", "Yangtze", "Mississippi"}, 0),
            new Question("What is the most populous city in the world?", new List<string>() {"Tokyo", "Delhi", "Shanghai", "São Paulo"}, 0),
            new Question("What is the chemical symbol for gold?", new List<string>() {"Au", "Ag", "Cu", "Fe"}, 0),
            new Question("Who painted the Mona Lisa?", new List<string>() {"Leonardo da Vinci", "Michelangelo", "Raphael", "Sandro Botticelli"}, 0),
            new Question("What year did World War II start?", new List<string>() {"1939", "1941", "1943", "1945"}, 0),
            new Question("What is the currency of Japan?", new List<string>() {"Yen", "Yuan", "Euro", "Dollar"}, 0),
            new Question("What is the national animal of India?", new List<string>() {"Tiger", "Lion", "Elephant", "Rhinoceros"}, 0)
        };

            List<Contender> contenders = new List<Contender>()
        {
            new Contender("Alice", 0.8),
            new Contender("Bob", 0.7),
            new Contender("Charlie", 0.6)
        };

            // Game loop
            foreach (Question question in questions)
            {
                // Ask the question
                Console.WriteLine($"\nQuestion: {question.Text}");
                for (int i = 0; i < question.Options.Count; i++)
                {
                    Console.WriteLine($"  {i + 1}. {question.Options[i]}");
                }

                // Get player answer
                int answer = int.Parse(Console.ReadLine()) - 1;

                // Check answer and handle bullshitting
                if (answer == question.Answer)
                {
                    Console.WriteLine("Correct!");
                    player.Score++;
                }
                else
                {
                    HandleIncorrectAnswer(question, player, contenders);
                }
            }

            // End message
            Console.WriteLine($"\nCongratulations, {player.Name}! You answered {player.Score} questions correctly.");
        }

        private static void HandleIncorrectAnswer(Question question, Player player, List<Contender> contenders)
        {
            Console.WriteLine("Incorrect!");

            bool bullshitSuccess = false;
            foreach (Contender contender in contenders)
            {
                Random random = new Random(); // Create an instance of Random
                if (random.NextDouble() < contender.Gullibility)
                {
                    bullshitSuccess = true;
                    break;
                }
            }

            if (bullshitSuccess)
            {
                Console.WriteLine("However, you managed to bullshit your way through!");
                player.Score++;
            }
        }
    } }
