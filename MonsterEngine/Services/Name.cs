using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterEngine
{
    class Name
    {
        /// <summary>
        /// Get Monster Name
        /// </summary>
        /// <returns>Generates a random name based on two arrays of strings.</returns>
        public static string GetName()
        {
            Random rand = new Random();
            string[] name = new string[] {
                "Bob",
                "William",
                "Xavier",
                "Javier",
                "Dino",
                "Julio",
                "Mike",
                "Wilfred",
                "Ferdinand",
                "Kellie",
                "Maxine",
                "Lois",
                "Luis",
                "Jimmy",
                "Tim",
                "Roger",
                "Nicholas"};

            string[] descriptor = new string[]
            {
                "Flatulent",
                "Hairy",
                "Obtuse",
                "Persnickety",
                "Annoying",
                "Fierce",
                "Wild",
                "Lonely",
                "Vicious",
                "Dumb",
                "Genius",
                "Shrubber",
                "Gardner",
                "Finger-Painter",
                "Savage",
                "Cunning",
                "Daring",
                "Obnoxious",
                "Sarcastic",
                "Over-bearing",
                "Strong",
                "Weak",
                "Hairless"
            };

            var fname = name[rand.Next(name.Length)];
            var lname = descriptor[rand.Next(descriptor.Length)];

            return $"{fname} the {lname}";
        }

    }
}
