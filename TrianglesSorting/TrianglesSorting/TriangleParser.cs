// <copyright file="TriangleParser.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using System;
using System.Text;
using System.Text.RegularExpressions;
using TriangleModel;

namespace TrianglesSorting
{
    public static class TriangleParser
    {
        private const int PARAMETERS_COUNT = 4;

        public static Triangle Parse(string[] args)
        {
            StringBuilder stringArgs = new StringBuilder();
            foreach(string arg in args)
            {
                stringArgs.Append(arg);
            }
            
            string pattern = @"\s+";
            Regex regex = new Regex(pattern);
            string result = regex.Replace(stringArgs.ToString(), string.Empty);
            string[] parameters = result.Split(new char[] { ',' });
            if (parameters.Length == 0)
            {
                throw new ArgumentNullException("Please, add arguments!");
            }

            if (parameters.Length != PARAMETERS_COUNT)
            {
                throw new ArgumentException("You do not have correct number of arguments!");
            }

            try
            {
                string name = parameters[0];
                float a;
                float b;
                float c;
                if (!float.TryParse(parameters[1], out a) | !float.TryParse(parameters[2], out b) | !float.TryParse(parameters[3], out c))
                {
                    throw new ArgumentException("You arguments are not valid! Cannot conver to float! Check your input parameters!");
                }

                return Triangle.Initialize(name, a, b, c);
            }
            catch (InvalidTriangleException exception)
            {
                throw new ArgumentException(exception.ToString());
            }
        }

        public static Triangle Parse(string input)
        {
            string pattern = @"\s+";
            Regex regex = new Regex(pattern);
            string result = regex.Replace(input, string.Empty);
            string[] parameters = result.Split(new char[] { ',' });
            if (parameters.Length > PARAMETERS_COUNT)
            {
                throw new ArgumentException("Too many arguments! Please, enter the correct number of arguments!");
            }

            if (parameters.Length < PARAMETERS_COUNT)
            {
                throw new ArgumentException("You do not have enought arguments! Please, enter the correct number of arguments!");
            }
            
            Triangle triangle;
            try
            {
                string parameterName = parameters[0].ToLower();
                string parameterA = parameters[1].Replace(".", ",");
                string parameterB = parameters[2].Replace(".", ",");
                string parameterC = parameters[3].Replace(".", ",");
                triangle = Triangle.Initialize(
                    parameterName,
                    float.Parse(parameterA),
                    float.Parse(parameterB),
                    float.Parse(parameterC));                
            }
            catch (InvalidTriangleException exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
            catch (FormatException)
            {
                Console.WriteLine("Can not convert from float to double! Please, input correct parameters!");
                return null;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Can not convert from float to double! Please, input correct parameters!");
                return null;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Can not convert from float to double! Please, input correct parameters!");
                return null;
            }

            return triangle;
        }
    }
}