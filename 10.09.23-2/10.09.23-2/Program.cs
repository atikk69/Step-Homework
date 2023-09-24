#region Part1

/*
using System.ComponentModel.Design;

try
{
    int dollar = int.Parse(Console.ReadLine());
    int cents = int.Parse(Console.ReadLine());

    Product tv = new Product(dollar,cents);
    tv.Info();
    tv.Less(50,30);
    
    tv.Info();
    
}

catch (MoneyException ex)
{
    Console.WriteLine(ex);
}


abstract class Money
{
    private int _dollars;
    private int _cent;
    
    public int Dollars
    {
        get => _dollars;
        set
        {
            if (value < 0)
                throw new MoneyException("Ошибка. Деньги не могут быть отрицательными");
            _dollars = value;  
        }
    }
    public int Cent
    {
        get => _cent;
        set
        {
            if (value < 0)
                throw new MoneyException("Ошибка. Деньги не могут быть отрицательными");
            if (value >= 100)
            {
                Dollars += value / 100;
                _cent = value % 100;
            }
            else
                _cent = value;

        }
    }

}

class Product : Money
{
    public Money Money { get; set; }
    
    
    public Product(int dollars, int cent)
    {
        Dollars = dollars;
        Cent = cent;
    }

    public void Less(int dollar, int cent)
    {
        Dollars -= dollar;
        Cent -= cent;
    }
    
    
    public void Info()
    {
        Console.WriteLine($"{Dollars} Dollar {Cent} cent");
    }

   
}

class MoneyException : Exception
{
    public string Message { get; private set; }

    public MoneyException(string message) : base(message)
    {
        Message = message;
    }

    public override string ToString()
    {
        return $"Error message: {Message}";
    }
}
*/

#endregion

#region Part2

/*
using System.Diagnostics.Tracing;



Automobile automobile = new Automobile("Car", "Color");
Microwave microwave = new Microwave("Microwave", "White");
Kettle kettle = new Kettle("Kettle", "Black");
Steamship steamship = new Steamship("Steamship", "Pink");

automobile.Show();
automobile.Desc();

abstract class Device
{
    public abstract string Name { get; set; }
    public abstract string Color { get; set; }




    public virtual void Sound(){}
    public virtual void Show(){}
    public virtual void Desc(){}
}


class Kettle : Device
{
    private string _name;
    private string _color;

    
    public override string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                throw new Exception("String is empty!");
            else
                _name = value;
        }

    }

    public override string Color 
    {   get=>_color;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                throw new Exception("String is empty!");
            else
                _color = value;
        }
    }

    public Kettle(string name, string color)
    {
        Name = name;
        Color = color;
    }

    public override void Sound()
    {
        Console.WriteLine("Makes a whistle sound");
    }

    public override void Show()
    {
        Console.WriteLine($"Name: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine("A teapot is a source of comfort and aromatic tea.");
    }
}

class Microwave : Device
{
    private string _name;
    private string _color;
    
    public override string Name { 
        get => _name;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                throw new Exception("String is empty!");
            _name = value;
        }
    }

    public override string Color
    {
        get=>_color;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                throw new Exception("String is empty!");
            _color = value;
        }
        
    }
    
    public Microwave(string name, string color)
    {
        Name = name;
        Color = color;
    }

    public override void Sound()
    {
        Console.WriteLine("Sound microwawe");
    }

    public override void Show()
    {
        Console.WriteLine($"Name: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine("The microwave is a source of quick and tasty cooking.");
    }
}

class Automobile : Device
{
    private string _name;
    private string _color;
    
    public override string Name { 
        get => _name;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                throw new Exception("String is empty!");
            _name = value;
        }
    }

    public override string Color
    {
        get=>_color;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                throw new Exception("String is empty!");
            _color = value;
        }
        
    }
    
    public Automobile(string name, string color)
    {
        Name = name;
        Color = color;
    }

    public override void Sound()
    {
        Console.WriteLine("Car sound");
    }

    public override void Desc()
    {
        Console.WriteLine("A car means freedom of movement and adventure.");
    }

    public override void Show()
    {
        Console.WriteLine($"Name: {Name}");
    }
}


class Steamship : Device
{
    private string _name;
    private string _color;
    
    public override string Name { 
        get => _name;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                throw new Exception("String is empty!");
            _name = value;
        }
    }

    public override string Color
    {
        get=>_color;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                throw new Exception("String is empty!");
            _color = value;
        }
        
    }
    
    public Steamship(string name, string color)
    {
        Name = name;
        Color = color;
    }
    
    public override void Show()
    {
        Console.WriteLine($"Name: {Name}");
    }

    public override void Sound()
    {
        Console.WriteLine("Sound steamship");
    }

    public override void Desc()
    {
        Console.WriteLine("Steamboat - a symbol of sailing and adventure on open waters");
    }
}
*/



#endregion

#region Part3

/*using System.Threading.Channels;*/

/*
abstract class MusicalInstrument
{
    
    public abstract void Sound();
    public abstract void Show();
    public abstract void Desc();
    public abstract void History();
    
    
}

class Violin : MusicalInstrument
{
    public string Name { get; set; } = "Violin";

    public override void Sound()
    {
        Console.WriteLine($"{Name} sound");
    }

    public override void Desc()
    {
        Console.WriteLine("Elegant and melodic, the violin is a stringed musical instrument with a long neck and bow.");
    }

    public override void History()
    {
        Console.WriteLine("The violin was developed in the 16th century in Italy and has since become one of the most popular instruments in the world.");
    }

    public override void Show()
    {
        Console.WriteLine($"Name: {Name}");
    }
}



class Trombone : MusicalInstrument
{
    public string Name { get; set; } = "Trombone";

    public override void Sound()
    {
        Console.WriteLine($"{Name} sound");
    }

    public override void Desc()
    {
        Console.WriteLine("Description: The trombone is a brass instrument with a long pipe and a retractable sectional comb that changes the pitch of the sound.");
    }

    public override void History()
    {
        Console.WriteLine("The trombone has been known since the Renaissance and remains an important part of orchestral music.");
    }

    public override void Show()
    {
        Console.WriteLine($"Name: {Name}");
    }
}



class Ukulele : MusicalInstrument
{
    public string Name { get; set; } = "Ukulele";

    public override void Sound()
    {
        Console.WriteLine($"{Name} sound");
    }

    public override void Desc()
    {
        Console.WriteLine("The ukulele is a small stringed instrument with four strings that creates bright and cheerful sounds.");
    }

    public override void History()
    {
        Console.WriteLine("The ukulele was developed in Hawaii in the 19th century and quickly gained popularity due to its unique sonority.");
    }

    public override void Show()
    {
        Console.WriteLine($"Name: {Name}");
    }
}


class Cello : MusicalInstrument
{
    public string Name { get; set; } = "Cello";

    public override void Sound()
    {
        Console.WriteLine($"{Name} sound");
    }

    public override void Desc()
    {
        Console.WriteLine("The cello is a large stringed instrument that is played with a bow and produces a rich, deep sound.");
    }

    public override void History()
    {
        Console.WriteLine("The cello was developed in the 16th century and became an integral part of symphony orchestras and chamber music.");
    }

    public override void Show()
    {
        Console.WriteLine($"Name: {Name}");
    }
}
*/



#endregion

#region Part4

/*
using System.Runtime.CompilerServices;

abstract class Worker
{
    public abstract void Print();
}

class Security : Worker
{
    public override void Print()
    {
        Console.WriteLine("Security");
    }
}

class Manager : Worker
{
    public override void Print()
    {
        Console.WriteLine("Manager");
    }
}

class Engineer : Worker
{
    public override void Print()
    {
        Console.WriteLine("Engineer");
    }
}

class President : Worker
{
    public override void Print()
    {
        Console.WriteLine("President");
    }
}
*/



#endregion
