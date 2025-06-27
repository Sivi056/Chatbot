using System;
using System.Collections.Generic;
using System.IO;
using NAudio.Wave;
using System.Threading;

namespace Chatbot
{
    public class Chatbot
    {
        private string userName;
        private string userInterest;
        private Dictionary<string, Tuple<string, string>> responses;
        private List<string> funFacts;
        private List<(string Question, string Answer)> quizQuestions;
        private Random random;

        public Chatbot()
        {
            random = new Random();
            InitializeResponses();
            InitializeFunFacts();
            InitializeQuizQuestions();
        }

        // Public property to access fun facts
        public List<string> FunFacts => funFacts;

        // Get response based on user input
        public string GetResponse(string input)
        {
            string lowerInput = input.ToLower();

            if (responses.ContainsKey(lowerInput))
            {
                var response = responses[lowerInput];
                return $"{response.Item1}\n{response.Item2}";
            }
            return "I didn't understand that. Here are some topics you can ask about:\n- Malware\n- Phishing\n- Social Engineering\n- Ransomware\n- Network Security\n- Cloud Security\n- IoT Security\n- Data Protection";
        }

        // Initialize responses to user queries
        private void InitializeResponses()
        {
            responses = new Dictionary<string, Tuple<string, string>>()
            {
                { "malware", Tuple.Create(
                    "Description: Malicious software designed to harm or gain unauthorized access to computer systems.",
                    "Prevention: Install reputable antivirus software and avoid suspicious links."
                )},
                { "phishing", Tuple.Create(
                    "Description: Deceptive attempts to trick individuals into revealing sensitive information.",
                    "Prevention: Be skeptical of unsolicited requests and verify the sender's identity."
                )},
                { "social engineering", Tuple.Create(
                    "Description: Manipulating individuals to gain access to systems or information.",
                    "Prevention: Implement strong access controls and train employees to recognize social engineering tactics."
                )},
                { "ransomware", Tuple.Create(
                    "Description: Malware that encrypts files and demands ransom.",
                    "Prevention: Regularly back up your data and keep software updated."
                )},
                { "network security", Tuple.Create(
                    "Description: Protecting computer networks and systems from digital attacks.",
                    "Prevention: Use firewalls, intrusion detection systems, and VPNs."
                )},
                { "cloud security", Tuple.Create(
                    "Description: Securing data and applications stored in the cloud.",
                    "Prevention: Implement strong access controls, encryption, and monitoring."
                )},
                { "iot security", Tuple.Create(
                    "Description: Protecting Internet of Things devices from cyber threats.",
                    "Prevention: Update firmware regularly and use strong passwords."
                )},
                { "data protection", Tuple.Create(
                    "Description: Safeguarding sensitive information from unauthorized access and breaches.",
                    "Prevention: Implement data encryption, access controls, and regular backups."
                )}
            };
        }

        // Initialize fun facts
        private void InitializeFunFacts()
        {
            funFacts = new List<string>
            {
                "Did you know? The first computer virus was created in 1986 and was called 'Brain'.",
                "Fun Fact: Phishing emails can be very convincing!",
                "Interesting: In 2020, the FBI reported a 300% increase in reported cybercrimes.",
                "Fun Fact: Human error is responsible for 85% of data breaches.",
                "Interesting: A strong password should mix upper and lower-case letters, numbers, and special symbols."
            };
        }

        private void InitializeQuizQuestions()
        {
            quizQuestions = new List<(string Question, string Answer)>
            {
                ("What does MFA stand for?", "Multi-Factor Authentication"),
                ("What is ransomware?", "Malware that encrypts files for ransom"),
                ("What should you do with suspicious emails?", "Do not open them"),
                ("What is the purpose of a firewall?", "To block unauthorized access"),
                ("What is phishing?", "Deceptive attempts to steal information")
            };
        }

        public (string Question, string Answer) GetQuizQuestion()
        {
            int index = random.Next(quizQuestions.Count);
            return quizQuestions[index];
        }

        // Share a fun fact
        public string GetFunFact()
        {
            int index = random.Next(funFacts.Count);
            return funFacts[index];
        }

        // Play a welcome sound
        private void PlayWelcomeSound()
        {
            string audioFilePath = @"C:\path\to\your\soundfile.wav"; // Update the path to your audio file

            try
            {
                if (File.Exists(audioFilePath))
                {
                    using (var audioFile = new AudioFileReader(audioFilePath))
                    using (var outputDevice = new WaveOutEvent())
                    {
                        outputDevice.Init(audioFile);
                        outputDevice.Play();
                        while (outputDevice.PlaybackState == PlaybackState.Playing)
                        {
                            Thread.Sleep(100);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Audio file not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
