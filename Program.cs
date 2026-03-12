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
        Console.WriteLine("=== БУДИНОК МОДИ: ===\n");

        Console.WriteLine("1. SINGLETON:");
        var manager1 = FabricWarehouse.GetInstance();
        manager1.AddFabric("Шовк");
        var manager2 = FabricWarehouse.GetInstance(); 
        manager2.AddFabric("Вовна");
        manager2.ShowStatus(); 
        Console.WriteLine();

        Console.WriteLine("2. FACTORY:");
        var accessoryFactory = new AccessoryFactory();
        Console.WriteLine($"- Зроблено: {accessoryFactory.CreateAccessory("bag").GetName()}");
        Console.WriteLine($"- Зроблено: {accessoryFactory.CreateAccessory("belt").GetName()}");
        Console.WriteLine($"- Зроблено: {accessoryFactory.CreateAccessory("scarf").GetName()}");
        Console.WriteLine();

        Console.WriteLine("3. FACTORY METHOD:");
        Atelier dressAtelier = new DressAtelier();
        Atelier coatAtelier = new CoatAtelier();
        Console.WriteLine($"- Цех 1 зшив: {dressAtelier.CreateGarment().GetDescription()}");
        Console.WriteLine($"- Цех 2 зшив: {coatAtelier.CreateGarment().GetDescription()}");
        Console.WriteLine();

        Console.WriteLine("4. ABSTRACT FACTORY:");
        Boutique summerBoutique = new Boutique(new SummerCollectionFactory());
        Console.Write("- Літній сезон -> ");
        summerBoutique.ShowShowcase();
        Boutique winterBoutique = new Boutique(new WinterCollectionFactory());
        Console.Write("- Зимовий сезон -> ");
        winterBoutique.ShowShowcase();
        Console.WriteLine();

        Console.WriteLine("5. BUILDER:");
        var director = new FashionDirector();
        var silkBuilder = new SilkDressBuilder();
        var cottonBuilder = new CottonDressBuilder();
        director.Construct(silkBuilder);
        director.Construct(cottonBuilder);
        Console.WriteLine($"- Замовлення 1: Сукня, тканина - {silkBuilder.GetResult().Fabric}");
        Console.WriteLine($"- Замовлення 2: Сукня, тканина - {cottonBuilder.GetResult().Fabric}");
        Console.WriteLine();

        Console.WriteLine("6. PROTOTYPE:");
        var baseDressPattern = new DressPattern("M");
        var baseTrousersPattern = new TrousersPattern("Кльош");
        var clonedDress = (DressPattern)baseDressPattern.Clone();
        var clonedTrousers = (TrousersPattern)baseTrousersPattern.Clone();
        Console.WriteLine($"- Клон лекала сукні. Розмір: {clonedDress.Size}");
        Console.WriteLine($"- Клон лекала штанів. Стиль: {clonedTrousers.Style}");

        Console.ReadLine();
    }
}