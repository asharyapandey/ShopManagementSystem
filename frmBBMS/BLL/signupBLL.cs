using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmBBMS.BLL
{
    class signupBLL
    {
        DBConnection dbms = new DBConnection();
        private string fName;
        private string lName;
        private string dateOfBirth;
        private string address;
        private string phone;
        private string gender;
        private string nationality;
        private string userID;
        private string username;
        private string password;

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
        public void setUserID(string userID)
        {
            this.userID = userID;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        //
        string query;
        public void insert()
        {
            query = "insert into adminInfo(fName, lName, dateofBirth, phone, address, gender, nationality,username,password) values ('" +
                   fName + "','" +
                   lName + "','" +
                   dateOfBirth + "','" +
                   phone + "','" +
                   address + "','" +
                   gender + "','" +
                   nationality + "','" +
                   username + "','" +
                   password +
                   "');";
            dbms.manipulate(query);
        }
        public void delete()
        {
            query = "delete from adminInfo where username='" + userID + "'";
            dbms.manipulate(query);
        }
        public void update()
        {
            query = "update adminInfo set fName='" + fName +
                    "',lName='" + lName +
                    "',dateofBirth='" + dateOfBirth +
                    "',phone='" + phone +
                    "',address='" + address +
                    "',gender='" + gender +
                    "',nationality='" + nationality +
                    "',username='" + username +
                    "',password='" + password +
                    "' where username='" + userID + "';" +
                    "";
            dbms.manipulate(query);
        }
        DataTable dt;
        public DataTable select()
        {

            query = "select fname,lName,dateofBirth,phone,address,nationality,username,password,gender from adminInfo details where username='" + userID + "'";
            dt = dbms.retrieve(query);
            return dt;
        }
        public DataTable loadGrid()
        {// to load the data grid
            string query = "select * from adminInfo;";
            dt = dbms.retrieve(query);
            return dt;

        }
    }
}
