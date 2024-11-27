using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace PDP_Deliveries
{
    internal class Booking
    {

        string firstname, lastname, address, returnaddress,shippingtime, parcelvol, weight,tracking, customernumber;
        int noofpackages;
        double cost;


        public Booking(string firstname, string lastname, string address, string returnaddress, int noofpackages, string shippingtime, string parcelvol, string weight, string tracking, double cost, string customernumber) 
        { 
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.returnaddress = returnaddress;
            this.noofpackages = noofpackages;
            this.shippingtime = shippingtime;
            this.parcelvol = parcelvol;
            this.weight = weight;
            this.tracking = tracking;
            this.cost = cost;
            this.customernumber = customernumber;

        }

        //getters and setters
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string ReturnAddress
        {
            get { return returnaddress; }
            set { returnaddress = value; }
        }
        public int NoOfPackages
        {
            get { return noofpackages; }
            set { noofpackages = value; }
        }
        public string ShippingTime
        {
            get { return shippingtime; }
            set { shippingtime = value; }
        }
        public string ParcelVol
        {
            get { return parcelvol; }
            set { parcelvol = value; }
        }
        public string Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string Tracking
        {
            get { return tracking; }
            set { tracking = value; }
        }
        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public string CustomerNumber
        {
            get { return customernumber; }
            set { customernumber = value; }
        }
    }
}
