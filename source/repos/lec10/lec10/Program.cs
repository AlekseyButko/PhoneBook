namespace lec10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            personList.Add(new Person("Alex",23));
            personList.Add(new Person("Taras", 21));
            personList.Add(new Person("Misha", 21));
            personList.Add(new Person("Anya", 45));

            for ( int i = 0; i < personList.Count; i++ ) 
            {
                for(int j = i+1; j< personList.Count; j++ ) 
                {
                    if (personList[i] < personList[j]) 
                    {
                        Console.WriteLine($"{personList[i].GetInfo()} age is less than {personList[j].GetInfo()} age");
                    }
                    if (personList[i] > personList[j])
                    {
                        Console.WriteLine($"{personList[i].GetInfo()} age is greater than {personList[j].GetInfo()}");
                    }
                    if (personList[i] == personList[j])
                    {
                        Console.WriteLine($"{personList[i].GetInfo()}  name and age or just age equals {personList[j].GetInfo()}");
                    }
                }
            }
        }
    }
}