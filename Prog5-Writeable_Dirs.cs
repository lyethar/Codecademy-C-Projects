using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using System.Linq.Expressions;

namespace WriteablePaths
{
    public class Program
    {

        public void GetWriteable(string[] arg)
        {
            // Command Line arguments, the directory will be taken from the user
            string root = arg[0];
            // filter that says if the second argument is null, then it will enumerate for all file types
            string filter; 
            if (arg.Length > 1)
            {
                filter = arg[1]; 
            }
            else
            {
                filter = "*";
            }
            /* Gets directories in the root */
            var directories = Directory.EnumerateDirectories(root);

            /* for each directory that is shown it will try to enumerate permissions on binaries using the File.Open function */
            foreach (string directory in directories)
            {
               
                // for each directory it will enuemrate files and put them onto a variable

                try
                {
                
               
                    var files = Directory.EnumerateFiles(directory, filter, SearchOption.AllDirectories);
                    

                    foreach (string file in files)
                    {
                        // each file will be 
                        try
                        {
                            FileStream fs = File.Open(file, FileMode.Open, FileAccess.ReadWrite);

                            Console.WriteLine($"Write access on: {file}");
                        }
                        catch { }

                    }



                }
                catch { }
            }

        }

        static void Main(string[] args)
        {
            /* Direcotry we want to enumerate */
           // string root = args[0];

            /* This is necessary since you cannot get an instance of a public method into a static main method */
            /* Creating a new variable type progrma will allow you to do this or alternatevily use static for hte other method */
            Program c = new Program();


            c.GetWriteable(args);
           
            

        }
    }
}
