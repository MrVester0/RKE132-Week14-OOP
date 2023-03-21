Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);


Dog neighboursDog = new Dog("Bubby");


Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}.");

myDog.Rename("Bad Boy");
//Console.WriteLine($"Level of happiness is: {myDog.LevelofHappiness}");

//myDog.Bark();
//Console.WriteLine($"Level of happiness is: {myDog.LevelofHappiness}");

while (myDog.LevelofHappiness != 5)
{
    myDog.Bark();
}


myDog.WagTail();


class Dog
{
    private string _name; //field
    private int _levelofHappiness;

    //constructor
    public Dog(string name) //name - lets the user nam the dog
    {
        _name = name;
        _levelofHappiness = 0;

    }

    //getter
    public string Name
    {
        get{ return _name; }
    }

    public int LevelofHappiness
     {
        get { return _levelofHappiness; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }


    public void Bark()
    {
        Console.WriteLine("Woof-woof!");
        _levelofHappiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle");
    }
        
}
