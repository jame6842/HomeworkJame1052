using System;
class Program{
    public static void Main(string[] args){
        Console.Write("Please input StoreName : ");
        string storename = Console.ReadLine();
        Console.Write("Please input Number : ");
        string number = Console.ReadLine();
        Console.Write("Please input Owner Name : ");
        string shopmanager = Console.ReadLine();
        Console.Write("Please input Registered Value : ");
        int cost = int.Parse(Console.ReadLine());
        store mediastore = CreateStore(storename,shopmanager,number,cost);
        PrintstoreInformation(mediastore);
    }
    public static store CreateStore(string storename,string shopmanager,string number,int cost) 
    {
    return new store(storename,shopmanager,number,cost);
    }
    static void PrintstoreInformation (store Store){
      Console.WriteLine("-------Shop Information------");
      Console.WriteLine("Name : {0}",Store.storename);
      Console.WriteLine("Number : {0}",Store.number);
      Console.WriteLine("Owner Name : {0}",Store.shopmanager);
      Console.WriteLine("Register Value : {0}",Store.cost);

}
}