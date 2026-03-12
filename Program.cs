using System;
using FashionAtelierApp.Creational;

using System;
using FashionAtelierApp.Creational.Singleton;
using FashionAtelierApp.Creational.Factory;
using FashionAtelierApp.Creational.FactoryMethod;
using FashionAtelierApp.Creational.AbstractFactory;
using FashionAtelierApp.Creational.Builder;
using FashionAtelierApp.Creational.Prototype;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Тестування патернів Будинку Моди ---\n");

        // 1. Singleton
        FabricWarehouse.GetInstance().ShowStatus();

        // 2. Factory
        var accessory = new AccessoryFactory().CreateAccessory("bag");
        Console.WriteLine($"Factory: {accessory.GetName()}");

        // 3. Factory Method
        Atelier atelier = new DressAtelier();
        Console.WriteLine($"Factory Method: {atelier.CreateGarment().GetDescription()}");

        // 4. Abstract Factory
        ICollectionFactory collection = new SummerCollectionFactory();
        Console.WriteLine($"Abstract Factory: {collection.CreateClothing().GetDetails()} та {collection.CreateShoes().GetDetails()}");

        // 5. Builder
        var builder = new SilkDressBuilder();
        new FashionDirector().Construct(builder);
        Console.WriteLine($"Builder: Сукня з тканини {builder.GetResult().Fabric}");

        // 6. Prototype
        var originalPattern = new DressPattern("M");
        var copiedPattern = (DressPattern)originalPattern.Clone();
        Console.WriteLine($"Prototype: Скопійовано викройку розміру {copiedPattern.Size}");
    }
}