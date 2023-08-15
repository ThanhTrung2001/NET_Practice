// See https://aka.ms/new-console-template for more information
////Singleton
//var singletonRunner = new SingletonRunner();
//singletonRunner.RunSingleTon();
//-------
////FactoryMethod
//var factoryCreator = new Creator();
//var db = factoryCreator.GetDatabase("SQL");
//db.OpenConnection(100);
//-------
////Buider
//IBuilder builder = new ConcreteBuilder();
////Add ZaloPay
//builder.AddZaloPayPurchase();
//builder.GetList();
//Console.WriteLine("-----------------");
//builder.AddMomoPurchase();
//builder.GetList();

////Adapter
//NoteAdaptee noteAdaptee = new NoteAdaptee();
//Adapter adapter = new Adapter(noteAdaptee);
//await adapter.GetDataForNote(url: "https://jsonplaceholder.typicode.com/todos/1");
//-------
////Decorator
//IAccountSecurity accountSecurity = new Account();
////Login with no layer?
//accountSecurity.Login();
////Login with 1 layer
//Decorator firstLayer = new FirstLayer(accountSecurity);
//firstLayer.Login();
////login with 3 layers
//Decorator secondLayer = new SecondLayer(firstLayer);
//Decorator thirdLayer = new ThirdLayer(secondLayer);
//thirdLayer.Login();
//-------
////Facade
//using DesignPattern.Structural.Facade;
//Facade.GetInstance().DefendAirSpace();
//-------
//Bridge
