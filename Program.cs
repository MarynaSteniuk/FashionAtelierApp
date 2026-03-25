using System;
using FashionAtelierApp.Creational;

using System;
using FashionAtelierApp.Creational.Singleton;
using FashionAtelierApp.Creational.Factory;
using FashionAtelierApp.Creational.FactoryMethod;
using FashionAtelierApp.Creational.AbstractFactory;
using FashionAtelierApp.Creational.Builder;
using FashionAtelierApp.Creational.Prototype;
using FashionAtelierApp.Structural.Adapter;
using FashionAtelierApp.Structural.Bridge;
using FashionAtelierApp.Structural.Composite;
using FashionAtelierApp.Structural.Decorator;
using FashionAtelierApp.Structural.Facade;
using FashionAtelierApp.Structural.Flyweight;
using FashionAtelierApp.Structural.Proxy;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== БУДИНОК МОДИ: ===\n");
        Console.WriteLine("=== ПОРОДЖУВАЛЬНІ ПАТЕРНИ ===\n");
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
        Console.WriteLine();

        Console.WriteLine("=== СТРУКТУРНІ ПАТЕРНИ ===\n");
        Console.WriteLine("1. ADAPTER:");
        ImperialSystem clientMeasurements = new ImperialSystem(); 
        MetricAdapter adapter = new MetricAdapter(clientMeasurements); 
        EuropeanTailor tailor = new EuropeanTailor(); 
        Console.WriteLine($"  {tailor.Sew(adapter)}");
        Console.WriteLine();

        Console.WriteLine("2. BRIDGE:");
        IPrint floralPrint = new FloralPrint();
        IPrint checkeredPrint = new CheckeredPrint();
        Garment eveningDress = new EveningDress(floralPrint);
        Garment winterCoat = new FashionAtelierApp.Structural.Bridge.WinterCoat(checkeredPrint);
        Console.WriteLine($"  {eveningDress.Manufacture()}");
        Console.WriteLine($"  {winterCoat.Manufacture()}");
        Console.WriteLine();

        Console.WriteLine("3. COMPOSITE:");
        GarmentItem shirt = new GarmentItem("Біла сорочка");
        GarmentItem tie = new GarmentItem("Шовкова краватка");
        OutfitSet businessSuit = new OutfitSet("Діловий костюм");
        businessSuit.Add(shirt);
        businessSuit.Add(tie);
        Lookbook springCollection = new Lookbook("Весна 2026");
        springCollection.Add(businessSuit);
        FashionShow show = new FashionShow();
        show.StartShow(springCollection);
        Console.WriteLine();

        Console.WriteLine("4. DECORATOR:");
        FashionAtelierApp.Structural.Decorator.IClothing myDress = new BasicDress();
        Console.WriteLine($"  {myDress.GetDescription()} | Вартість: {myDress.GetPrice()} грн");
        myDress = new LaceDecorator(myDress);
        myDress = new CrystalDecorator(myDress);
        Console.WriteLine($"  {myDress.GetDescription()} | Вартість: {myDress.GetPrice()} грн");
        Console.WriteLine();

        Console.WriteLine("5. FACADE:");
        AtelierFacade facade = new AtelierFacade();
        facade.CompleteOrder();
        Console.WriteLine();

        Console.WriteLine("6. FLYWEIGHT:");
        ButtonFactory buttonFactory = new ButtonFactory();
        TailorsDesk desk = new TailorsDesk(buttonFactory);
        desk.SewButtonToGarment(ButtonType.Pearl, "Весільна сукня");
        desk.SewButtonToGarment(ButtonType.Pearl, "Вечірня сукня");
        desk.SewButtonToGarment(ButtonType.Pearl, "Блузка");
        Console.WriteLine($"  [ПЕРЕВІРКА]: Всього створено об'єктів ґудзиків у пам'яті: {buttonFactory.GetCacheSize()}");
        Console.WriteLine();

        Console.WriteLine("7. PROXY:");
        Customer regularCustomer = new Customer("Олена", false);
        Customer vipCustomer = new Customer("Марина", true);
        VIPCollectionProxy proxy1 = new VIPCollectionProxy(regularCustomer);
        VIPCollectionProxy proxy2 = new VIPCollectionProxy(vipCustomer);
        Console.WriteLine($"  {proxy1.ViewCollection()}");
        Console.WriteLine($"  {proxy2.ViewCollection()}");

        Console.ReadLine();
    }
}