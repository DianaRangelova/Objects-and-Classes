namespace P03_Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string input = Console.ReadLine();

            while (input != "end") 
            {
                string[] inputParams = input.Split();
                string serialNumber = inputParams[0];
                string itemName = inputParams[1];
                int itemQuantity = int.Parse(inputParams[2]);
                double itemPrice = double.Parse(inputParams[3]);

                Item item = new Item()
                {
                    Name = itemName,
                    Price = itemPrice
                };

                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    ItemObject = item,
                    ItemQuantity = itemQuantity,
                    Price = itemPrice * itemQuantity
                };

                boxes.Add(box);

                input = Console.ReadLine();
            }

            List<Box> orderBoxes = boxes
                .OrderByDescending(b => b.Price)
                .ToList();

            foreach (var box in orderBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.ItemObject.Name} - ${box.ItemObject.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.Price:F2}");
            }
        }
    }
}

class Item 
{ 
    public string Name { get; set; }
    public double Price { get; set; }
}

class Box
{
    public string SerialNumber { get; set; }
    public Item ItemObject { get; set; }
    public int ItemQuantity { get; set; }
    public double Price { get; set; }
}