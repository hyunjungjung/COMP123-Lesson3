using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    /**
     * This class is the "driver" class for our Program
     * 
     * @class Program
     */
    public class Program
    {
        /**
         * the main method for our driver class Program
         * 
         * @method Main
         * @param {string[]} args
         */
        public static void Main(string[] args)
        {
            // create a new instance of the Person Class
            Person person;
            person = new Person("Tom");

            Console.WriteLine(person.Name);
            // set a value in the Name property of the Person Class
            //person.Name = "Tom";

            // get the Name value and print to console
            Console.WriteLine(person.Name);

            
            
        }

    }
}
