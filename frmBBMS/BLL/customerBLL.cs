using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace frmBBMS.BLL
{
    class customerBLL
    {
        DBConnection dbms = new DBConnection();
        private string fName;
        private string lName;
        private string dateOfBirth;
        private string address;
        private string phone;
        private string gender;
        private string nationality;
        private int customerID;

        //SETTERS
        public void setFirstName(string fName)
        {
            this.fName = fName;
        }
        public void setLastName(string lName)
        {
            this.lName = lName;
        }
        public void setDate(string dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }
        public void setPhone(string phone)
        {
            this.phone = phone;
        }
        public void setGender(string gender)
        {
            this.gender = gender;
        }
        public void setNationality(string nationality)
        {
            this.nationality = nationality;
        }
        public void setCustomerID(int customerID)
        {
            this.customerID=customerID ;
        }
        string query;
        public void insert()
        {
            query = "insert into customerDetails(fName, lName, dateofBirth, phone, address, gender, nationality) values ('" +
                    fName + "','" +
                    lName + "','" +
                    dateOfBirth + "','" +
                    phone + "','" +
                    address + "','" +
                    gender + "','" +
                    nationality +
                    "');";
            dbms.manipulate(query);
        }
        public void delete()
        {
            query = "delete from customerDetails where CustomerID=" + customerID;
            dbms.manipulate(query);
        }
        public void update()
        {
            query = "update customerDetails set fName='" + fName +
                    "',lName='" + lName +
                    "',dateofBirth='" + dateOfBirth +
                    "',phone='" + phone +
                    "',address='" + address +
                    "',gender='" + gender +
                    "',nationality='" + nationality +
                    "' where customerID=" + customerID;
            dbms.manipulate(query);
        }
        DataTable dt;
        public DataTable select()
        {
            query = "select fname,lName,dateofBirth,phone,address,nationality,gender from customerDetails details where customerID=" + customerID;
            dt = dbms.retrieve(query);
            return dt;
        }
        public DataTable loadGrid()
        {
            string query = "select * from customerDetails order by customerID desc;";
            dt = dbms.retrieve(query);
            return dt;

        }



    }
}
