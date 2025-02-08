
////objeto
//using System.Reflection.Metadata.Ecma335;

//var sale = new SaleWithTax(15, 116m);

//var message = sale.GetInfo();

//Console.WriteLine(message);

////Sale juan = new Sale();

////Herencia de la clase Sale
//class SaleWithTax : Sale
//{

//    public decimal  Tax { get; set; }
//    public SaleWithTax(decimal total, decimal tax) : base(total)
//    {
//        Tax = tax;
//    }

//    public string GetInfoWithTaxt()
//    {
//        return "El total es " + Total  + "Impuesto es: "+Tax;
//    }

//    //sobrecarga de metodos 
//    public string GetInfo(string message) 
//    {
//        return message;
//    }
//}




////definimos la clase
//class Sale
//{
//    public decimal Total { get; set; }
//    private decimal some; // nadie mas puede acceder a ella es privada
//    public Sale(decimal total)
//    {
//        this.Total = total;
//    }

//    //comportamiento de la clase
//    public string GetInfo()
//    {
//        return "El total es " + Total;
//    }
//}





////Interfaces
//interface ISale
//{
//    decimal Total { get; set; }
//}


//interface ISave
//{
//    void Save();
//}


//public class Sole: ISale, ISave
//{
//    public decimal Total { get; set; }

//    public void Save()
//    {
//        Console.WriteLine("se guardo en Bd");
//    }

//    void Some(ISave save)
//    {
//        save.Save();
//    }

//}

//public class Cerveza : ISave
//{
//    public void Save()
//    {
//        Console.WriteLine("se guardo en el servicio");
//    }
//}


//Generic

//var numbers = new Mylist<int>(5);
//var names = new Mylist<string>(5);
//var beers = new Mylist<beer>(5);




//numbers.Add(1);
//numbers.Add(2);
//numbers.Add(3);
//numbers.Add(4);
//numbers.Add(5);
//numbers.Add(6);

//names.Add("Juan");
//names.Add("andres");
//names.Add("perez");
//names.Add("martinez");
//names.Add("jesus");
//names.Add("bien");

//beers.Add(new beer()
//{
//    Name ="Erdinger",
//    Price = 5
//});
//beers.Add(new beer()
//{
//    Name = "Corone",
//    Price = 1
//});

//beers.Add(new beer()
//{
//    Name = "Aguila",
//    Price = 15
//});



//Console.WriteLine(numbers.GetContent());
//Console.WriteLine(names.GetContent());
//Console.WriteLine(beers.GetContent());
//public class Mylist<T>
//{
//    private List<T> _list;
//    private int _limit;

//    public Mylist(int limit) {
//        _limit = limit;
//        _list = new List<T>();
//    }

//    public void Add(T element)
//    {
//        if(_list.Count < _limit)
//        {
//            _list.Add(element);

//        }


//    }

//    public string GetContent()
//    {
//        string content = "";
//        foreach (var  element in _list)
//        {
//            content += element + ", ";

//        }

//        return content; 
//    }

//}

//public class beer
//{
//    public string Name { get; set;  }

//    public decimal Price { get; set; }

//    public override string ToString()
//    {
//        return "Nombre: " + Name + " Price: " + Price;
//    }

//}

using System.Text.Json;


//SERIALIZACION  Y DESERIALIZACION




//PROGRAMACION  FUNCIONAL
Console.WriteLine(Sub(2,1));
int  Sub(int a, int b)
{
    return a + b;
}

var show = Show;

show("Hola mundo");

void Show (string message)
{
    Console.WriteLine(message);
}

