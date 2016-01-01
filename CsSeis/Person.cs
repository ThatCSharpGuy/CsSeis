namespace CsSeis
{
    public class Person
    {
        public Person Parent { get; set; }
        public string Name { get; } = "Cosme Fulanito";
        public int Age { get; set; } = 0;

        public Person(string name = null, int age = -1)
        {
            if(name != null)
                Name = name;

            if (age >= 0)
                Age = age;
        }

        public string SayHi() => $"Hi, my name is {Name} and I'm {Age}";

        public string SayHi(string greetingPerson) => $"Hi {greetingPerson}, my name is {Name} and I'm {Age}";
    }
}
