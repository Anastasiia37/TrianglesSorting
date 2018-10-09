using System;
using System.Text.RegularExpressions;

namespace TrianglesSorting
{
    public class Validator
    {
        public Triangle Check(string[] args)
        {
            if (args.Length == 0)
            {
                this.ShowInstruction();
                throw new InvalidArgumentException("Please, add arguments");
            }
            else
            {
                if (args.Length != 4)
                {
                    throw new InvalidArgumentException("You do not have enought arguments");
                }

                string name = args[0];
                //Проверка на отрицательные значение и удовлетворение параметрам треугольника
                float a;
                float b;
                float c;
                if (!float.TryParse(args[1], out a) | !float.TryParse(args[2], out b) | !float.TryParse(args[3], out c))
                {
                    throw new InvalidArgumentException("You arguments are not valid");
                }

                return new Triangle(name, a, b, c, new HeronsFormula());
            }
        }

        public Triangle StringParse(string input)
        {
            string pattern = @"\s+";
            Regex regex = new Regex(pattern);
            string result = regex.Replace(input, string.Empty);
            string[] parameters = result.Split(new char[] { ',' });

            if (parameters.Length > 4)
            {
                throw new InvalidArgumentException("Too much parameters");
            }
            else if (parameters.Length < 4)
            {
                throw new InvalidArgumentException("Too few parameters");
            }

            Triangle triangle;
            try
            {
                string name_parameter = parameters[0].ToLower();
                string a_parameter = parameters[1].Replace(".", ",");
                string b_parameter = parameters[2].Replace(".", ",");
                string c_parameter = parameters[3].Replace(".", ",");
                triangle = new Triangle(
                    name_parameter, 
                    float.Parse(a_parameter),
                    float.Parse(b_parameter), 
                    float.Parse(c_parameter), 
                    new HeronsFormula());
            }
            catch
            {
                throw new InvalidArgumentException("Check your input parameters!");
            }

            return triangle;
        }

        public void ShowInstruction()
        {
            Console.WriteLine("Input parameters: name,length,length,length");
        }
    }
}
