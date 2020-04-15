using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace frmBBMS.BLL
{
    class BLLBill
    {
        DBConnection dbms = new DBConnection();
        private int billNumber;
        private int itemCode;
        private int customerID;
        private int rate;
        private int quantity;
        private float total;
        private int newBill;

        public void setBillNumber(int billNumber)
        {
            this.billNumber = billNumber;
        }
        public void setItemCode(int itemCode)
        {
            this.itemCode = itemCode;
        }
        public void setCustomerID(int customerID)
        {
            this.customerID = customerID;
        }
        public void setRate(int rate)
        {
            this.rate = rate;
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public void setTotal(float total)
        {
            this.total = total;
        }
        public void setNewBill(int newBill)
        {
            this.newBill = newBill;
        }
        string query;
        public void insert()
        {
            query = "insert into billItem(billNumber,itemCode,customerID,quantity,total,date) values(" + billNumber + "," + itemCode + "," +
                customerID + "," + quantity + "," + total + ",'" + DateTime.Today.ToShortDateString() + "')";
            dbms.manipulate(query);
        }
        public DataTable retriveBill()
        {
            //load bill number
            string query = "select * from bill order by billNumber desc;";
            DataTable dt = dbms.retrieve(query);
            return dt;
        }
        public DataTable loadGrid()
        {
            string query = "select i.itemCode,i.itemName,i.rate,b.quantity,b.total from item as i,billItem as b where b.itemCode = i.itemCode and b.billNumber=" + billNumber;
            DataTable dt = dbms.retrieve(query);
            return dt;

        }
        public DataTable calculateSum()
        {
            string query = "select sum(total) from billItem where billNumber=" + billNumber;
            DataTable dt = dbms.retrieve(query);
            return dt;
        }
        public void delete()
        {
            query = "delete from billItem where itemCode=" + itemCode;
            dbms.manipulate(query);
        }
        public DataTable retriveCustomer()
        {
            query = "select fName,Lname,dateofBirth,phone,address from customerDetails where customerID=" + customerID;
            DataTable dt = dbms.retrieve(query);
            return dt;
        }
        public DataTable retriveItem()
        {
            query = "select itemName,rate from item where itemCode=" + itemCode;
            DataTable dt = dbms.retrieve(query);
            return dt;
        }
        public DataTable loadCombo()
        {
            //loding combo box
            string query = "select itemCode,itemName from item;";
            DataTable dt = dbms.retrieve(query);
            return dt;
          
        }
        public void Click()
        {
            billNumber++;
            query = "insert into bill values(" + billNumber + ")";//increase bill number
            dbms.manipulate(query);
        }
        //Generate bill
        public DataTable generateBillRetrive()
        {
            string query = "select i.itemName,i.rate,b.quantity,b.total from item as i,billItem as b where b.itemCode = i.itemCode and b.billNumber=" + billNumber;
            DataTable dt = dbms.retrieve(query);
            return dt;
        }

    }
}
