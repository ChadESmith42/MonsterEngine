using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterEngine.Services
{
    class DescriptionHelper
    {
        /// <summary>
        /// Generates a description for the monster.
        /// </summary>
        /// <returns>Picks a random description from an array.</returns>
        public static string GenerateDescription()
        {
            Random rand = new Random();
            string[] descriptions = new string[]
            {
                "A wiley beast, but not very strong.",
                "His breath is the strongest thing about him.",
                "Small a fury, he's got sharp, pointy teeth.",
                "Looks like an advark, without the charm.",
                "Large and covered with orange fur. For some reason, it's wearing Air Jordans.",
                "Large, scaly, and with huge antlers. This is repulsive.",
                "A cute little rabbit, but covered in the blood of it's last victim.",
                "A continously moving cloud of smoke and debris. This could get messy.",
                "Fangs. It has fangs on it's fangs. Let's just say, there are lots of teeth involved.",
                "A rodent of unusual size. They do exist."
            };

            return descriptions[rand.Next(descriptions.Length)];
        }
    }
}
