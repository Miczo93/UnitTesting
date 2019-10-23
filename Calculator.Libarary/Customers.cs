using System.Collections;

namespace Calculator.Libarary
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public override bool Equals(object obj)
        {
            Customer otherCustomer = obj as Customer;
            if (otherCustomer==null)
            {
                return false;
            }
            return this.FirstName == otherCustomer.FirstName && this.LastName == otherCustomer.LastName;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }

    public class SuperCustomer: Customer
    {

    }
    public class CustomerComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Customer c1 = x as Customer;
            Customer c2 = y as Customer;

            if (c1 == null || c2 == null)
            {
                return -1;
            }
            // return c1.FirstName.CompareTo(c2.FirstName);
            if (c1.FirstName == c2.FirstName && c1.LastName == c2.LastName)
            {
                return 0;
            }
            return -1;
           
        }

    }

}

