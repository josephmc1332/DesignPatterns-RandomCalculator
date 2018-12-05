using System;

namespace MiddleLayer
{
    public class CustomerBase
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }
        public virtual void Validate()
        {
            throw new Exception("Not implemented");
        }
    }
    public class Customer : CustomerBase
    {
        public override void Validate()
        {
            if(CustomerName.Length == 0)
            {
                throw new Exception("Customer Name is required");               
            }
            if(PhoneNumber.Length == 0)
            {
                throw new Exception("Phone Number is required");
            }
            if(BillAmount == 0)
            {
                throw new Exception("Bill Amount is required");
            }
            if(BillDate >= DateTime.Now)
            {
                throw new Exception("Bill Date is not proper");
            }
            if(Address.Length == 0)
            {
                throw new Exception("Adress is required");
            }

        }

    }
    public class Lead : CustomerBase
    {
        public override void Validate()
        {
            if (CustomerName.Length == 0)
            {
                throw new Exception("Customer Name is required");
            }
            if (PhoneNumber.Length == 0)
            {
                throw new Exception("Phone Number is required");
            }
        }
    }
}
