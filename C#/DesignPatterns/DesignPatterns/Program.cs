using System;
using DesignPatterns.StartegyDesign;
using DesignPatterns.StartegyDesign.Behaviours;
using DesignPatterns.ObserverPattern.Interfaces;
using DesignPatterns.ObserverPattern.Concretes;
using DesignPatterns.DecoratorPattern.ConcreteComponents;
using DesignPatterns.DecoratorPattern.ConcreteDecorators;
using DesignPatterns.CommandPattern.Receivers;
using DesignPatterns.CommandPattern.Invokers;
using DesignPatterns.CommandPattern.ConcreteCommands;
using DesignPatterns.AdapterPattern.Client;
using DesignPatterns.AdapterPattern;
using DesignPatterns.BridgePattern.Abtraction;
using DesignPatterns.BridgePattern.ConcreteAbstraction;
using DesignPatterns.BridgePattern.ConcreteImplementation;
using DesignPatterns.BridgePattern;
using DesignPatterns.TemplateMethodPattern.AbstractClasses;
using DesignPatterns.TemplateMethodPattern.ConcreteClasses;
using DesignPatterns.StatePattern.Context;
using DesignPatterns.StatePattern.State;

namespace DesignPatterns
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Strategy design test:
            /*var loudDuck = new Duck(new LoudQuack());
            var neuroticDuck = new Duck(new Longquack());
            var cuteDuck = new Duck(new CuteQuack());

            loudDuck.Quack();
            neuroticDuck.Quack();
            cuteDuck.Quack();*/

            //Observer Pattern Testing:

            //WeatherStation weatherStation = new WeatherStation(23.3f);
            //Console.WriteLine(weatherStation.temperature);
            //FlatScreenDisplay flatScreenDisplay = new FlatScreenDisplay(weatherStation);
            //weatherStation.Add(flatScreenDisplay);

            //flatScreenDisplay.showTemp();

            //weatherStation.setTemperature(26.6f);

            //Caramel Soy esspresso
            //SoyMilk caramelSoyEspresso = new SoyMilk(new Caramel(new Espresso()));
            //Console.WriteLine("Express With Caramel & Soy: ${0}", caramelSoyEspresso.Cost());

            ////Triiple Caramel Double Soy Latte
            //Caramel latte = new Caramel(new Caramel(new Caramel(new SoyMilk(new SoyMilk(new Latte())))));
            //Console.WriteLine("Late With Caramel (x3) & Soy (x2): ${0}", latte.Cost());

            //Command Pattern Test
            //LightBulb lightBulb = new LightBulb();


            //LightBulbRemoteControlInvoker remoteControl =
            //new LightBulbRemoteControlInvoker(new LightOnCommand(lightBulb),
            //new LightOffCommand(lightBulb));

            //remoteControl.ClickOn();
            //remoteControl.ClickOff();

            //Adapter Pattern Testing
            //where Drawing editor is the client, Shape is the ITarget, TextshapeAdapter is the adapter
            //and TextView is the adaptee

            //LineShape lineShape = new LineShape();
            //SquareShape squareShape = new SquareShape();
            //TextShapeAdapter textShape = new TextShapeAdapter(new TextView());

            //DrawingEditor editor = new DrawingEditor();
            //editor.Add(lineShape); editor.Add(squareShape); editor.Add(textShape);

            //editor.drawAll();

            //Book b1 = new Book("The Lord of The Rings", "Legolas", 
            //"www.jrrtolkien.com", "Doom is upon Middle Earth");
            //Book b2 = new Book("Harry Potter", "Harry",
            //"www.jkrowling.com", "Voldemort returns!");

            //Album a1 = new Album("A night at the Opera", "4 queens!", "www.queen.com", "BoRhap!");
            //Album a2 = new Album("Thriller", "MJ with red jacket!", "www.mj.com", "Thriller again!");



            //LongFormView lfv1 = new LongFormView(new AlbumResource(a1));
            //LongFormView lfv2 = new LongFormView(new BookResource(b1));

            //ShortFormView sfv1 = new ShortFormView(new AlbumResource(a2));
            //ShortFormView sfv2 = new ShortFormView(new BookResource(b2));

            //Console.WriteLine(lfv1.Show());
            //Console.WriteLine(lfv2.Show());
            //Console.WriteLine(sfv1.Show());
            //Console.WriteLine(sfv2.Show());

            //Model user = new User();
            //Model post = new Post();
            //user.Save();
            //post.Save();

            Gate gate = new Gate();
            ClosedGateState closed = new ClosedGateState(gate);
            gate.State = closed;

            gate.Pay();
            gate.PayOK();
            gate.Enter();



        }
    }
}
