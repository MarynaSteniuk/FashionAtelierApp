using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Memento
{
    public class DressDesign
    {
        public string Color { get; set; }
        public string Fabric { get; set; }
        public string Style { get; set; }

        public void PrintState()
        {
            System.Console.WriteLine($"[Ескіз] Колір: {Color}, Тканина: {Fabric}, Стиль: {Style}");
        }
        public DesignMemento Save()
        {
            System.Console.WriteLine(" Збережено бекап ескізу.");
            return new DesignMemento(Color, Fabric, Style);
        }
        public void Restore(DesignMemento memento)
        {
            Color = memento.Color;
            Fabric = memento.Fabric;
            Style = memento.Style;
            System.Console.WriteLine(" Дизайн успішно відновлено до попередньої версії!");
        }
    }
}
