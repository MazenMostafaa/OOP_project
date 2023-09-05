using System;
using System.IO;
namespace project;

interface Cars
{

    protected string Name { set; get; }
    protected int Id { set; get; }

    protected string Color { set; get; }

    protected double Price { set; get; }

    public void Add_Data();


}

class Model_1 : Cars
{
    public string Name { set; get; }
    public int Id { set; get; }

    public string Color { set; get; }

    public double Price { set; get; }


    public Model_1()
    {
        this.Name = "null";
        this.Id = 0;
        this.Color = "null";
        this.Price = 0;
    }
    public Model_1(int id, string name, string color, double price)
    {
        this.Id = id;
        this.Name = name;
        this.Color = color;
        this.Price = price;
    }

    public void Add_Data()
    {

        File.AppendAllText("Model_1.txt", "(Name) " + this.Name + " \t " + "(ID) " + this.Id +
                 " \t " + "(Color) " + this.Color + " \t " + "(Price) " + this.Price + "\n");
        Console.WriteLine("Data is inserted successfully");
    }

    public void Select_id(int id)
    {

        if (id == this.Id)
        {
            Console.WriteLine(File.GetAttributes("Model_1.txt"));
        }
    }



}

class Model_2 : Cars
{
    public string Name { set; get; }
    public int Id { set; get; }

    public string Color { set; get; }

    public double Price { set; get; }

    public Model_2()
    {
        this.Name = "null";
        this.Id = 0;
        this.Color = "null";
        this.Price = 0;
    }

    public Model_2(int id, string name, string color, double price)
    {
        this.Id = id;
        this.Name = name;
        this.Color = color;
        this.Price = price;
    }

    public void Add_Data()
    {

        File.AppendAllText("Model_2.txt", "(Name) " + this.Name + " \t " + "(ID) " + this.Id +
           " \t " + "(Color) " + this.Color + " \t " + "(Price) " + this.Price + "\n");
        Console.WriteLine("Data is inserted successfully");
    }


}

class Model_3 : Cars
{
    public string Name { set; get; }
    public int Id { set; get; }

    public string Color { set; get; }

    public double Price { set; get; }

    public Model_3()
    {
        this.Name = "null";
        this.Id = 0;
        this.Color = "null";
        this.Price = 0;
    }
    public Model_3(int id, string name, string color, double price)
    {
        this.Id = id;
        this.Name = name;
        this.Color = color;
        this.Price = price;
    }
    public void Add_Data()
    {

        File.AppendAllText("Model_3.txt", "(Name) " + this.Name + " \t " + "(ID) " + this.Id +
         " \t " + "(Color) " + this.Color + " \t " + "(Price) " + this.Price + "\n");

        Console.WriteLine("Data is inserted successfully");

    }

}


class project
{

    public static void Main(String[] args)
    {
        string contin; int ch;
        do
        {
            Console.WriteLine("********** Menu Of Cars **********" +
                              "\n Choose only one number from these choices" +
                              "\n 1-Add to Model_1 \n 2-Add to Model_2 \n 3-Add to Model_3 " +
                              "\n 4-View cars in model_1 \n 5-View cars in model_2 \n 6-View cars in model_3 " +
                              "\n 7-Select from  model_1 ");


            ch = Int32.Parse(Console.ReadLine());

            if (ch == 1 || ch == 2 || ch == 3)
            {

                Console.Clear();

                Console.WriteLine("Please, enter the id of car :");
                int id = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Please, enter the name of car :");
                string name = Console.ReadLine();

                Console.WriteLine("Please, enter the color of car :");
                string color = Console.ReadLine();

                Console.WriteLine("Please, enter the price of car :");
                double price = Double.Parse(Console.ReadLine());


                switch (ch)
                {
                    case 1:
                        Model_1 obj1 = new Model_1(id, name, color, price);
                        obj1.Add_Data();
                        break;

                    case 2:
                        Model_2 obj2 = new Model_2(id, name, color, price);
                        obj2.Add_Data();
                        break;

                    case 3:
                        Model_3 obj3 = new Model_3(id, name, color, price);
                        obj3.Add_Data();
                        break;

                }

            }

            else
            {
                switch (ch)
                {
                    case 4:
                        Console.Clear();
                        Console.WriteLine(File.ReadAllText("Model_1.txt"));
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine(File.ReadAllText("Model_2.txt"));
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine(File.ReadAllText("Model_3.txt"));
                        break;

                    case 7:
                        Console.WriteLine("Enter an specific ID :");
                        int selectedId = Int32.Parse(Console.ReadLine());
                        Model_1 obj4 = new Model_1();
                        obj4.Select_id(selectedId);
                        break;
                }

                Console.WriteLine("These are all cars in this model.");

            }

            Console.WriteLine("If you wanna choose more options, Write (yes) otherwise Press whatever on keyboard.");
            contin = Console.ReadLine();

            Console.Clear();

        } while (contin == "yes");

    }
}