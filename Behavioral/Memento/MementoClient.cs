using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Memento
{
    public class MementoClient
    {
        public void RunMemento()
        {
            System.Console.WriteLine("--- ТЕСТ: ЗНІМОК (MEMENTO) ---");
            DesignerHistory history = new DesignerHistory();
            DressDesign design = new DressDesign { Color = "Білий", Fabric = "Бавовна", Style = "Повсякденний" };

            design.PrintState();
            history.Backup(design.Save());

            System.Console.WriteLine("\n...Дизайнер вирішив зробити сукню більш елегантною...");
            design.Color = "Чорний";
            design.Fabric = "Оксамит";
            design.Style = "Вечірній";
            design.PrintState();
            history.Backup(design.Save());

            System.Console.WriteLine("\n...Дизайнер вирішив поекспериментувати (вийшло погано)...");
            design.Color = "Кислотно-зелений";
            design.Fabric = "Мішковина";
            design.Style = "Авангард";
            design.PrintState();

            System.Console.WriteLine("Ой, цей дизайн жахливий! Тиснемо Ctrl+Z...");

            design.Restore(history.Undo());
            design.PrintState();

            design.Restore(history.Undo());
            design.PrintState();
        }
    }
}
