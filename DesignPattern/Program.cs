// See https://aka.ms/new-console-template for more information
using DesignPattern.Creational.Builder;
using DesignPattern.Creational.Builder.Interfaces;
////Singleton
//var singletonRunner = new SingletonRunner();
//singletonRunner.RunSingleTon();
////FactoryMethod
//var factoryCreator = new Creator();
//var db = factoryCreator.GetDatabase("SQL");
//db.OpenConnection(100);
//Buider
IBuilder builder = new ConcreteBuilder();
//Add ZaloPay
builder.AddZaloPayPurchase();
builder.GetList();
Console.WriteLine("-----------------");
builder.AddMomoPurchase();
builder.GetList();
