using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
// FIXME: Does System.ComponentModel need to be in all the files?
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainScreenForm());
        }
    }

    public class Inventory
    {
        public BindingList<Product> Products { get; }
        public BindingList<Part> AllParts { get; } // FIXME: do these need to get? Should I get/set in the methods below?

        public void InitializeProductsList()
        {
            // Create a new BindingList of type Product
            Products = new BindingList<Product>();
           
            Products.AllowNew = true; // FIXME: Is this necessary?

            Products.AllowEdit = true; // FIXME: Is this necessary?
            
            // FIXME: How do I list an associatedPart as an argument?
            Products.Add(new Product(1, "Engine", 3215.96M, 2, 1, 5));
            Products.Add(new Product(2, "Brake Assembly", 444.18M, 8, 5, 20));

        }

        public void InitializePartsList()
        {
            // Create a new BindingList of type Part
            AllParts = new BindingList<Part>();

            AllParts.AllowNew = true;

            AllParts.AllowEdit = true;

            AllParts.Add(new Inhouse("Piston", 113.24M, 6, 5, 25, 528491));
            AllParts.Add(new Outsourced("Crankshaft", 433.67M, 10, 5, 20, "BiffCo"));
            AllParts.Add(new Inhouse("Caliper", 233.41M, 6, 4, 25, 24601));
            AllParts.Add(new Outsourced("Rotor", 98.62M, 4, 2, 10, "OCP"));
        }

        public void addProduct(Product product)
        {
            Products.Add(product);
            // FIXME: Upon clicking the Add Product button, a new Product object is created using the arguments
            // supplied in the textboxes on the Add Product form. That object is then passed as an argument to
            // addProduct(), so be sure to call it when you click the Add Product button.
            // Would this work? Product newProduct1 = new Product(textBox1.Text, etc.);
            // addProduct(newProduct1);
        }

        public bool removeProduct(int p)
        {
            // FIXME: I think this will end up being "delete object from the binding list at index [p]"
            // This creates kind of a conundrum: the ProductID and its index are different
            // Am I going to be able to select a product in the datagridview?
        }

        public Product lookupProduct(int q)
        {
            // FIXME: This is going to be some LINQ stuff, I bet.
        }

        public void updateProduct(int q, Product p)
        {

        }

        public void addPart(Part p)
        {

        }

        public bool deletePart(int q)
        {

        }

        public Part lookupPart(int q)
        {
            // FIXME: This is going to be some LINQ stuff, I bet.
        }

        public void updatePart(int q, Part p)
        {

        }
    }

    public class Product
    {
        public BindingList<Part> AssociatedPart { get; } // FIXME: Do I need to be "get"ing here?
        public int ProductID { get; }
        public string Name { get; }
        public decimal Price { get; }
        public int InStock { get; }
        public int Min { get; }
        public int Max { get; }
        public int ProductsIDCounter;

        public void addAssociatedPart(Part part)
        {
            AssociatedPart.Add(part);
        }

        public bool removeAssociatedPart(int p)
        {
            AssociatedPart.RemoveAt(p);
            //FIXME: Using RemoveAt because I apparently only have an int (presumably the part's index) to work with.
        }

        public Part lookupAssociatedPart(int p)
        {
            // FIXME: This is going to be some LINQ stuff, I bet.
        }

        // Default constructor
        public Product()
        {

        }

        // Constructor containing all properties
        public Product(BindingList<Part> associatedPart, string name, decimal price, int inStock, int min, int max)
        {
            ++ProductsIDCounter;

            AssociatedPart = associatedPart;
            ProductID = ProductsIDCounter;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
    }

    public abstract class Part
    {
        // FIXME: Are these getter-only auto-implemented properties because this is an abstract class (and therefore should not produce objects? (is that right?))
        public int PartID { get; }
        public string Name { get; }
        public decimal Price { get; }
        public int InStock { get; }
        public int Min { get; }
        public int Max { get; }
        public int PartsIDCounter;

        // Default constructor
        public Part()
        {

        }

        // Constructor containing all properties
        public Part(string name, decimal price, int inStock, int min, int max)
        {
            ++PartsIDCounter;

            PartID = PartsIDCounter;
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
        public int machineID; // FIXME: Should this be a getter/setter auto-implemented property?

        public Inhouse(string name, decimal price, int inStock, int min, int max, int machineID)
        : base(name, price, inStock, min, max)
            // FIXME: Removed the partID parameter since I removed it from the Part constructor. Is that correct?
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
        public string companyName; // FIXME: Should this be a getter/setter auto-implemented property?

        public Outsourced(string name, decimal price, int inStock, int min, int max, string companyName)
        : base(name, price, inStock, min, max)
            // FIXME: Removed the partID parameter since I removed it from the Part constructor. Is that right?
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
