using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    private string _name = "N/A";
    private int _age = 0;

   
    // Declare a Name property of type string:
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    // Declare an Age property of type int:
    public int Age
    {
        get
        {
            return _age;
        }

        set
        {
            _age = value;
        }
    }

    public override string ToString()
    {
        return "Name = " + Name + ", Age = " + Age;
    }
   
}

public class Wrapper
{
    private string _name = "N/A";
    public string Name
    {
        get
        {
            return _name;
        }
        private set
        {
            _name = value;
        }
    }

}

class TestPerson
{
    static void Main()
    {
        Person person = new Person();

        Console.WriteLine("Person details - {0}", person);

        person.Name = "Joe";
        person.Age = 99;
        Console.WriteLine("Person details - {0}", person);


    }
}