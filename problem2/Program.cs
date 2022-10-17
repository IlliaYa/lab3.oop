using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    private string _name;
    private int _age;

    public Person()
    {//1st constructor
        this.Name = "No name";
        this.Age = 1;
    }//1st constructor

    public Person(int age)
    {//2nd constructor
        this.Name = "No name";
        this.Age = age;
    }//2nd constructor

    public Person(String name, int age)
    {//3rd constructor
        this.Name = name;
        this.Age = age;
    }
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

        
        int Age = 99;
        Person person1 = new Person(Age);
        Console.WriteLine("Person details - {0}", person1);

        string Name = "bob";
        Person person2 = new Person(Name, Age);
        Console.WriteLine("Person details - {0}", person2);


    }
}
