Dog sharik = new Dog("Гав", "Мясо", "будка", "Шарик"); //переменная для класса dog
sharik.makeNoise();
Cat murka = new Cat("Мяу", "Красная форель", "особняк", "Мурка"); //переменная для класса cat
murka.eat();
Horse julius = new Horse("Игого", "Сено", "у богатого мужчины(фермера)", "Юлий"); //переменная для класса horse
julius.sleep();
class Animal //суперкласс
{
    public string name;
    public string food; 
    public string location;
    public Animal (string food, string location, string name)
    {
        this.food = food;
        this.location = location;
        this.name = name;
    }
    public virtual void makeNoise() //виртуальный метод
    {
        Console.WriteLine(name);
    }
    public virtual void sleep() //виртуальный метод
    {
      
        Console.WriteLine(name);
    }
    public virtual void eat() //виртуальный метод
    {
        Console.WriteLine(name);
    }
   
}
class Dog : Animal //класс наследник
{ 
    public string noise; 

    public Dog (string noise, string food, string location, string name ) : base(food, location, name)
    {
        this.noise = noise;
    }
    public override void eat() //переопределяем метод
    {
        Console.WriteLine($"{name} ест");
    }
    public override void makeNoise() //переопределяем метод
    {
        Console.WriteLine($"{name} издаёт звуки {noise}");
    }
    public override void sleep() //переопределяем метод
    {
        Console.WriteLine($"{name} спит");
    }
}

class Cat : Animal //класс наследник
{
    public string noise;

    public Cat(string noise, string food, string location, string name) : base(food, location, name)
    {
        this.noise = noise;
    }
    public override void eat() //переопределяем метод
    {
        Console.WriteLine($"{name} ест");
    }
    public override void makeNoise() //переопределяем метод
    {
        Console.WriteLine($"{name} издаёт звуки {noise}");
    }
}
class Horse : Animal //класс наследник
{
    public string noise;

    public Horse(string noise, string food, string location, string name) : base(food, location, name)
    {
        this.noise = noise;
    }
    public override void eat() //переопределяем метод
    {
        Console.WriteLine($"{name} ест");
    }
    public override void makeNoise() //переопределяем метод
    {
        Console.WriteLine($"{name} издаёт звуки {noise}");
    }
    public override void sleep() //переопределяем метод
    {
        Console.WriteLine($"{name} спит");
    }
}

