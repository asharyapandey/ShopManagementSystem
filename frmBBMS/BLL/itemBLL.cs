using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace frmBBMS.BLL
{
    class itemBLL
    {
        DBConnection dbms = new DBConnection();
        private string itemName;
        private int itemRate;
        private int itemID;


        public void setName(string itemName)
        {
            this.itemName = itemName;
        }
        public void setRate(int itemRate)
        {
            this.itemRate = itemRate;
        }

        public void setItemID(int itemID)
        {
            this.itemID = itemID;
        }
        string query;
        public void insert()
        {
            query = "insert into item(itemName,rate) values('" + itemName + "'," + itemRate + ")";
            dbms.manipulate(query);

        }
        public void update()
        {
            query = "update item set itemName = '" + itemName + "', rate = '" + itemRate + "' where itemCode =" + itemID;
            dbms.manipulate(query);
        }
        public void delete()
        {
            query = "delete from item where itemCode=" + itemID;
            dbms.manipulate(query);

        }
        DataTable dt;
        public DataTable retrive()
        {
            query = "select itemName,rate from item where itemCode=" + itemID;
            dt = dbms.retrieve(query);
            return dt;
        }
        public DataTable loadData()
        {//loading data in data grid
            query = "select * from item order by itemCode desc;";
            dt = dbms.retrieve(query);
            return dt;
        }
    }
}
