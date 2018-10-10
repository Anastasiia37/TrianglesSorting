using System;
using System.Text.RegularExpressions;

namespace TrianglesSorting
{
    public static class TriangleValidator
    {
        const int PARAMETERS_COUNT = 4;
        public static Triangle Parse(string[] args)
        {
            if (args.Length == 0)
            {
                ShowInstruction();
                throw new InvalidArgumentException("Please, add arguments");
            }
            else
            {
                if (args.Length != PARAMETERS_COUNT)
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
                    throw new InvalidArgumentException("You arguments are not valid! Cannot conver to float! Check your input parameters!");
                }

                return new Triangle(name, a, b, c);
            }
        }

        public static Triangle Parse(string input)
        {
            string pattern = @"\s+";
            Regex regex = new Regex(pattern);
            string result = regex.Replace(input, string.Empty);
            string[] parameters = result.Split(new char[] { ',' });

            try
            {


                if (parameters.Length > PARAMETERS_COUNT)
                {
                    throw new IncorrectNumberOFArgumentsException("Too many arguments! Please, enter the correct number of arguments!");
                }
                else if (parameters.Length < PARAMETERS_COUNT)
                {
                    throw new IncorrectNumberOFArgumentsException("You do not have enought arguments! Please, enter the correct number of arguments!");
                }
            }
            catch (IncorrectNumberOFArgumentsException ex)
            {
                Console.WriteLine(ex);
                return null;
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
                    float.Parse(c_parameter));
                if (float.Parse(a_parameter) <= 0 || float.Parse(c_parameter) <= 0 || float.Parse(c_parameter) <= 0)
                {

                    throw new WrongTriangleException("Triangle can not have negative value of sides! Check your input parameters!", triangle);
                }
            }
            catch (WrongTriangleException ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            catch
            {
                throw new InvalidArgumentException("Cannot conver to float! Check your input parameters!");
            }
            return triangle;
        }

        public static void ShowInstruction()
        {
            Console.WriteLine("Input parameters: name,length,length,length");
        }
    }
}
