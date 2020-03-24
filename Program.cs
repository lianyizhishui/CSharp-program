using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order_manage
{
    public class Order {//订单
        private static int id;//订单号
        private string date;//下单日期
        private string address;//收货地址
        public  Order(int id, string date, string address){//构造方法
           Order.id = id;
            this.date = date;
            this.address = address ;
           
           
         }
        public static int Id {        //属性
            get { return id; }
            set { id = value; }
        }
        public string Date {
            get { return date; }
            set { date = value; }

        }
        public string Address {
            get { return Address ; }
            set { Address = value; }
        }
        public override bool Equals(object obj)
        {
            Order m = obj as Order;
            return m != null &&m.date==date&&
                m.address==address;
        }
        public override int GetHashCode()
        {
            return id;
        }
        public override string ToString()
        {
            return id + "-" + date+"-"+ address ;
        }
    }
    public class OrderItems
    {//订单明细
        private int id = Order.Id;
        private string clientName;//客户名字
        private string clientPhoneNumber;//客户联系方式（电话/手机号码）
        private int goodsQuantity;//订购的物品数量
        private double prices;//订单价格
        private bool isIntransit;//货物是否正在运输
        private bool isArrived;//货物是否到达
        private bool isCancelled;//订单是否被取消

        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }

        public string ClientPhoneNumber
        {
            get { return clientPhoneNumber; }
            set { clientPhoneNumber = value; }
        }

        public int GoodsQuantity
        {
            get { return goodsQuantity; }
            set { goodsQuantity = value; }

        }
        public double Prices
        {
            get { return prices; }
            set { prices = value; }

        }

        public bool IsIntransit
        {
            get { return isIntransit; }
            set { isIntransit = value; }
        }
        public bool IsArrived
        {
            get { return isArrived; }
            set { isArrived = value; }
        }
        public bool IsCancelled
        {
            get { return isCancelled; }
            set { isCancelled = value; }
        }
        public override bool Equals(object obj)
        {
            OrderItems m = obj as OrderItems;
            return m != null && m.clientName == clientName && m.clientPhoneNumber == clientPhoneNumber &&
                m.goodsQuantity == goodsQuantity&&m.prices==prices&&m.isIntransit==isIntransit&&m.isArrived
                ==isArrived&&m.isCancelled&&isCancelled;
        }
        public override int GetHashCode()
        {
            return id;
        }
        public override string ToString()
        {
            return clientName+"-"+clientPhoneNumber+"-"+goodsQuantity+"-"+prices+"-"+isIntransit+"-"+
                isArrived+ "isArrived?"+"-"+isCancelled+"isCancelled?";
        }
    }
    public class OrderService
    {


    }
    public class Client {
       
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
