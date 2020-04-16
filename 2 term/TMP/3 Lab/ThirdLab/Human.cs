﻿using System;

namespace ThirdLab
{
    public class Human
    {
        public string Name    { get; set; }
        public string Surname { get; set; }
        public int    Age     { get; set; }
        public Gender Gender  { get; set; }
        public string Country { get; set; }
        public Race   Race    { get; set; }
        public double Weight  { get; set; }
        public int Height  { get; set; }
        public static string PassportNumber { get; set; }


        public Human(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public Human(string name, string surname, int age, Gender gender, string country, Race race, double weight, int height, string passportNumber)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
            Country = country;
            Race = race;
            Weight = weight;
            Height = height;
            PassportNumber = passportNumber;
        }

        public override string ToString()
        {
            return "Person: " + Name    + "\t" + Surname + "\t" + Age  + "\n" +
                   "        " + Country + "\t" + Gender  + "\t" + Race + "\n" +
                   "        " + Weight  + "\t" + Height  + "\t" + PassportNumber + "\n"; 
        }

        public double BMICalculate()
        {
            return Weight / (Height * Height) * 10000;
        }
    }

    public enum Gender
    {
        Male,
        Female,
        Agender,
        Cisgender,
        GenderFluid,
        Intersex,
        Pangender,
        Transgender,
        Transsexual,
        TwoSplit,
        Other
    }

    public enum Race
    {
        White,
        Asian,
        Black
    }

    
}