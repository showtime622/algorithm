using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmConsole
{
    public class TreeTraverse
    {
        /// <summary>
        /// print out all files under some path
        /// </summary>
        /// <param name="path"></param>
        public static int count = 0;
        public static void traverseAllFiles(string path)
        {
            if(path.IsNullOrEmpty())
            {
                Console.WriteLine("Please type a path");
                return;
            }

            string[] files = Directory.GetFiles(path);
            Array.ForEach(files, (name) => {
                Console.WriteLine(string.Format("File found, the name is {0}", name));
                count++;
            });

            string[] paths = Directory.GetDirectories(path);

            for(int i = 0; i < paths.Length; i++)
            {
                traverseAllFiles(paths[i]);
            } 
        }

        public static string getSpecificFile(string path, string fileName)
        {
            if(path.IsNullOrEmpty())
            {
                Console.WriteLine("Please type a path");
                return "Pelase type a path";
            }

            string[] files = Directory.GetFiles(path);
            string tempName = "";
            Array.ForEach(files, (name) =>
            {
                if(name.Contains(fileName))
                {
                    tempName = name;
                }
            });

            if(!tempName.IsNullOrEmpty())
            {
                return tempName;
            }

            string[] dires = Directory.GetDirectories(path);

            for(int i = 0; i < dires.Length; i++)
            {
                string temp = getSpecificFile(dires[i], fileName);
                if (!temp.IsNullOrEmpty())
                {
                    return temp;
                }
            }

            return "";
        }
    }
}
