using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Magazine FirstMagazine = new Magazine();
            Magazine SecondMagazine = new Magazine();
            // += Methods
            FirstMagazine += 10;
            SecondMagazine -= 10;
            // Equal Methods
            Console.WriteLine(SecondMagazine == FirstMagazine);
            Console.WriteLine(SecondMagazine != FirstMagazine);
            Console.WriteLine(SecondMagazine.Equals(FirstMagazine));

            // Compare Methods
            Console.WriteLine(SecondMagazine > FirstMagazine);
            Console.WriteLine(SecondMagazine < FirstMagazine);

        }

        class Magazine
        {
            private string Name { get; set; }
            private string FoundationYear { get; set; }
            private string Description { get; set; }
            private string Number { get; set; }
            private string Email { get; set; }
            private int Employees { get; set; }

            public Magazine()
            {
                Name = "";
                FoundationYear = "";
                Description = "";
                Number = "";
                Email = "";
                Employees = 0;
            }
            public Magazine(string Name, string Year, string Description, string Number, string Email, int Employees)
            {
                this.Name = Name;
                this.FoundationYear = Year;
                this.Description = Description;
                this.Number = Number;
                this.Email = Email;
                this.Employees = Employees;
            }
            public void Input()
            {
                Console.WriteLine("Enter Name: ");
                this.Name = Console.ReadLine();
                Console.WriteLine("Enter Foundation Year: ");
                this.FoundationYear = Console.ReadLine();
                Console.WriteLine("Enter Description: ");
                this.Description = Console.ReadLine();
                Console.WriteLine("Enter Number: ");
                this.Number = Console.ReadLine();
                Console.WriteLine("Enter Email: ");
                this.Email = Console.ReadLine();
            }
            public void ChangeName(string Name)
            {
                this.Name = Name;
            }
            public void ChangeYear(string Year)
            {
                this.FoundationYear = Year;
            }
            public void ChangeDescription(string Description)
            {
                this.Description = Description;
            }
            public void ChangeNumber(string Number)
            {
                this.Number = Number;
            }
            public void ChangeEmail(string Email)
            {
                this.Email = Email;
            }
            public override string ToString()
            {
                return string.Format
                    (
                    $"\nName: {Name}" +
                    $"\nyear: {FoundationYear}" +
                    $"\nDescription: {Description}" +
                    $"\nNumber: {Number}" +
                    $"\nEmail: {Email}" +
                    $"\nEmployees: {Employees}"
                    );
            }

            public static Magazine operator +(Magazine result, int Employees)
            {
                result.Employees += Employees;
                return result;
            }
            public static Magazine operator -(Magazine result, int Employees)
            {
                result.Employees -= Employees;
                return result;
            }
            public static bool operator ==(Magazine result, Magazine Compare)
            {
                if (result.Employees == Compare.Employees)
                    return true;
                else
                    return false;
            }
            public static bool operator !=(Magazine result, Magazine Compare)
            {
                if (result.Employees != Compare.Employees)
                    return true;
                else
                    return false;
            }
            public static bool operator >(Magazine result, Magazine Compare)
            {
                if (result.Employees > Compare.Employees)
                    return true;
                else
                    return false;
            }
            public static bool operator <(Magazine result, Magazine Compare)
            {
                if (result.Employees < Compare.Employees)
                    return true;
                else
                    return false;
            }
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }
                Magazine other = (Magazine)obj;
                return Employees == other.Employees;
            }



        }
    }
}
