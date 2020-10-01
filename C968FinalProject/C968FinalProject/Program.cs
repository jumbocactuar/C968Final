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

    public static class Counters
    {
        public static int ProductsIDCounter { get; set; }
        public static int PartsIDCounter { get; set; }
        public static int SelectedPartIndex { get; set; }
        public static int SelectedProductIndex { get; set; }
        public static Part SelectedPartObject { get; set; }
        public static Product SelectedProductObject { get; set; }
    }

    public class Inventory // FIXME: Should this whole class be static? Just the methods/properties?
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static void addProduct(Product product)
        {
            product.ProductID++;

            Products.Add(product);

            Counters.ProductsIDCounter++;
        }

        public static bool removeProduct(int p)
        {
            // If the Product has no associated parts, remove the Product. Else, do not remove it and display a warning message.
            if (Products[p].AssociatedParts.Count == 0)
            {
                try
                {
                    Products.RemoveAt(p);

                    return true;
                }

                catch (Exception)
                {
                    return false;
                }
            }

            else
            {
                MessageBox.Show("This product is associated with at least one part.\n\nPlease remove all associated parts before deleting the product.");

                return false;
            }
        }

        /*public Product lookupProduct(int q)
        {
            // FIXME: This is going to be some LINQ stuff, I bet.
        }*/

        public static void updateProduct(int q, Product p)
        {
            // Replace the Product at index q with Product p
            Products[q] = p;
        }

        public static void addPart(Part part)
        {
            part.PartID++;

            AllParts.Add(part);

            Counters.PartsIDCounter++;
        }

        public static bool deletePart(int q)
        {
            try
            {
                AllParts.RemoveAt(q);

                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }

        /*public Part lookupPart(int q)
        {
            // FIXME: This is going to be some LINQ stuff, I bet.
        }
        */
        public static void updatePart(int q, Part p)
        {
            AllParts[q] = p;
        }
    }

    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; } // FIXME: Do I need to be "get"ing here?
        public int ProductID { get; set; } // FIXME: Should all these be "set"ing, too?
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public void addAssociatedPart(Part part)
        {
            Inventory.Products[Counters.SelectedProductIndex].AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int p)
        {
            try
            {
                Inventory.Products[Counters.SelectedProductIndex].AssociatedParts.RemoveAt(p);

                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }

        /*public Part lookupAssociatedPart(int p)
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
            AssociatedParts = associatedPart;
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
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

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

        public abstract string PartSource();

        /*public override string ToString() => $"{PartID}" + $"{Name}" + $"{Price:C}" + $"{InStock}" + $"{Min}" + $"{Max}"; // FIXME: Revisit this, see how it needs to be to fit into the datagridview

        // FIXME: The example has an abstract method used by the derived classes here--is it necessary?
        // Is this good? Is this necessary?
        public abstract string PartSource();
        // FIXME: I think I'll need something around here to allow switching of parts between in-house and outsourced - think of how to preserve part numbers
        // Can I say something like "if the part number exists, use it?" Will that data survive a move between classes? I think the object will get destroyed and recreated
        // when it moves between the two.
        // On second thought, is preserving the part number strictly necessary? Check the rubric.*/
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

        //public override string ToString() => $"{base.ToString()}" + $"{MachineID}";
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

        //public override string ToString() => $"{base.ToString()}" + $"{CompanyName}";
    }
}
