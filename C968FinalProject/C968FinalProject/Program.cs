using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace C968FinalProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize the parts list
            Inhouse a = new Inhouse(Counters.PartsIDCounter, "Piston", 113.24M, 6, 5, 25, 528491);
            Inventory.addPart(a);

            Outsourced b = new Outsourced(Counters.PartsIDCounter, "Crankshaft", 433.67M, 10, 5, 20, "BiffCo");
            Inventory.addPart(b);

            Inhouse c = new Inhouse(Counters.PartsIDCounter, "Caliper", 233.41M, 6, 4, 25, 24601);
            Inventory.addPart(c);

            Outsourced d = new Outsourced(Counters.PartsIDCounter, "Rotor", 98.62M, 4, 2, 10, "OCP");
            Inventory.addPart(d);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainScreenForm());
        }
    }

    public static class Counters // FIXME: Should this class be static?
    {
        public static int ProductsIDCounter;
        public static int PartsIDCounter;
    }

    public class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        // FIXME: Init products list needs to go, figure out how to list an associated part as an argument
        /*public void InitializeProductsList()
        {

            // Increment the ProductsIDCounter to generate a new ID for each product
            ++Counters.ProductsIDCounter;

            // FIXME: How do I list an associatedPart as an argument?
            Products.Add(new Product(1, Counters.ProductsIDCounter, "Engine", 3215.96M, 2, 1, 5));

            ++Counters.ProductsIDCounter;

            Products.Add(new Product(2, Counters.ProductsIDCounter, "Brake Assembly", 444.18M, 8, 5, 20));
        }*/

        public static void addProduct(Product product)
        {
            product.ProductID++;

            Products.Add(product);

            Counters.ProductsIDCounter++;
            // FIXME: Upon clicking the Add Product button, a new Product object is created using the arguments
            // supplied in the textboxes on the Add Product form. That object is then passed as an argument to
            // addProduct(), so be sure to call it when you click the Add Product button.
            // Would this work? Product newProduct1 = new Product(textBox1.Text, etc.);
            // addProduct(newProduct1);
            //FIXME: Remember to add a bit when creating a part to increment and assign ProductsIDCounter
        }

        /*public bool removeProduct(int p)
        {
            // FIXME: I think this will end up being "delete object from the binding list at index [p]"
            // This creates kind of a conundrum: the ProductID and its index are different
            // Am I going to be able to select a product in the datagridview?
            // Or am I just dealing with 0/1 here because the return type is bool?
        }*/

        /*public Product lookupProduct(int q)
        {
            // FIXME: This is going to be some LINQ stuff, I bet.
        }*/

        public void updateProduct(int q, Product p)
        {
            // FIXME: Implementation is at 13:37 in the webinar
        }

        public static void addPart(Part part)
        {
            part.PartID++;

            AllParts.Add(part);

            Counters.PartsIDCounter++;
        }

        /*public bool deletePart(int q)
        {

        }*/

        /*public Part lookupPart(int q)
        {
            // FIXME: This is going to be some LINQ stuff, I bet.
        }
        */
        public void updatePart(int q, Part p)
        {
            // FIXME: Implementation is at 13:37 in the webinar
        }
    }

    public class Product
    {
        public BindingList<Part> AssociatedPart; // FIXME: Do I need to be "get"ing here?
        public int ProductID { get; set; } // FIXME: Should all these be "set"ing, too?
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public void addAssociatedPart(Part part)
        {
            AssociatedPart.Add(part);
        }

        /*public bool removeAssociatedPart(int p)
        {
            AssociatedPart.RemoveAt(p);
            //FIXME: Using RemoveAt because I apparently only have an int (presumably the part's index) to work with.
            // Or since I'm returning a bool, is the int I'm working with 0/1 whether or not to remove the associated part?
        }

        public Part lookupAssociatedPart(int p)
        {
            // FIXME: This is going to be some LINQ stuff, I bet.
        }*/

        // Default constructor
        public Product()
        {

        }

        // Constructor containing all properties
        public Product(BindingList<Part> associatedPart, int productID, string name, decimal price, int inStock, int min, int max)
        {
            AssociatedPart = associatedPart;
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
    }

    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; }
        public decimal Price { get; }
        public int InStock { get; }
        public int Min { get; }
        public int Max { get; }

        // Default constructor
        public Part()
        {

        }

        // Constructor containing all properties
        public Part(int partID, string name, decimal price, int inStock, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public override string ToString() => $"{PartID}" + $"{Name}" + $"{Price:C}" + $"{InStock}" + $"{Min}" + $"{Max}"; // FIXME: Revisit this, see how it needs to be to fit into the datagridview

        // FIXME: The example has an abstract method used by the derived classes here--is it necessary?
        // Is this good? Is this necessary?
        public abstract string PartSource();
        // FIXME: I think I'll need something around here to allow switching of parts between in-house and outsourced - think of how to preserve part numbers
        // Can I say something like "if the part number exists, use it?" Will that data survive a move between classes? I think the object will get destroyed and recreated
        // when it moves between the two.
        // On second thought, is preserving the part number strictly necessary? Check the rubric.
    }

    public class Inhouse : Part
    {
        public int machineID;

        public Inhouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID)
        : base(partID, name, price, inStock, min, max)
        {
            MachineID = machineID;
        }

        public int MachineID
        {
            get
            {
                return machineID;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(MachineID)} must be >= 0");
                }

                machineID = value;
            }
        }

        public override string PartSource() => $"{MachineID}";

        public override string ToString() => $"{base.ToString()}" + $"{MachineID}";
    }

    public class Outsourced : Part
    {
        public string companyName;

        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string companyName)
        : base(partID, name, price, inStock, min, max)
        {
            CompanyName = companyName;
        }

        public string CompanyName
        {
            get
            {
                return companyName;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), $"{nameof(CompanyName)} must not be null");
                }

                companyName = value;
            }
        }

        public override string PartSource() => $"{CompanyName}"; // FIXME: Does this need the string interpolation stuff? It's already a string.

        public override string ToString() => $"{base.ToString()}" + $"{CompanyName}";
    }
}
