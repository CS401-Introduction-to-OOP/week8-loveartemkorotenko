using Week8;

var Letter = new Letter("123456", 0.1);
var Letter1 = new Letter("654321", 0.2);

var Parcel = new Parcel("654321", 3);
var Parcel2 = new Parcel("654321", 8);

Letter.PrintInfo();

Parcel.PrintInfo(); 

CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();

myCargo.AddItem(Letter);
myCargo.AddItem(Letter1);
myCargo.AddItem(Parcel);
myCargo.AddItem(Parcel2);

Console.WriteLine(myCargo.GetTotalCost());
