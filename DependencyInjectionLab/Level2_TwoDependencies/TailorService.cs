using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.DependencyInjectionLab
{
    public interface ITailorService
    {
        void SewGarment();
    }

    public class TailorService : ITailorService
    {
        private readonly IFabricWarehouse _warehouse;
        private readonly ISewingEquipment _equipment;

        public TailorService(IFabricWarehouse warehouse, ISewingEquipment equipment)
        {
            _warehouse = warehouse;
            _equipment = equipment;
        }

        public void SewGarment()
        {
            _warehouse.TakeFabric();
            _equipment.TurnOn();
            Console.WriteLine("✂️ Кравець успішно пошив замовлення.");
        }
    }
}
