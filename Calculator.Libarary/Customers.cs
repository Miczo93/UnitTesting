namespace Calculator.Libarary
{
    public class Customers
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            Customers otherCustomer = obj as Customers;
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
}

