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
////Bridge
//using DesignPattern.Structural.Bridge;
//using DesignPattern.Structural.Bridge.Interface;
//Developer fe = new FEDev(new FEJob());
//fe.WillWorkWith();
//Developer be = new BEDev(new BEJob());
//be.WillWorkWith();

////Observer
//using DesignPattern.Behavioral.Oserver;
//using DesignPattern.Behavioral.Oserver.Interfaces;

//ISubject YoutubeChannel = new Youtube();

//ISubcriber subcriber1 = new Subcriber(1);
//ISubcriber subcriber2 = new Subcriber(2);
//ISubcriber subcriber3 = new Subcriber(3);

//YoutubeChannel.Subcribe(subcriber1);
//YoutubeChannel.Subcribe(subcriber2);
//YoutubeChannel.Subcribe(subcriber3);
//YoutubeChannel.AddNotification();
////
//YoutubeChannel.UnSubcribe(subcriber1);
//YoutubeChannel.AddNotification();
////
//-------
////Strategy
//using DesignPattern.Behavioral.Strategy;
//ProblemNeedToSolve problem = new ProblemNeedToSolve();
//problem.SetProblemSovlingWay(new WayOne());
//problem.Solve();
//problem.SetProblemSovlingWay(new WayTwo());
//problem.Solve();
//problem.SetProblemSovlingWay(new WayThree());
//problem.Solve();
////Command
//using DesignPattern.Behavioral.Command;
//using DesignPattern.Behavioral.Command.Interface;
/////-------
//ICommand pushCode = new PushToRepo(Repository.GetInstance());
//ICommand pullCode = new PullFromRepo(Repository.GetInstance());
//GitInvoker gitInvoker = new GitInvoker(pushCode, pullCode);
//gitInvoker.Pull();
//gitInvoker.Push();
//-------
//Mediator
using DesignPattern.Behavioral.Mediator;

Red redLight = new Red();
Yellow yellowLight = new Yellow();
Green greenLight = new Green();

var trafficLight = new Mediator(redLight, yellowLight, greenLight);

redLight.Switch();

greenLight.Switch();

yellowLight.Switch();



