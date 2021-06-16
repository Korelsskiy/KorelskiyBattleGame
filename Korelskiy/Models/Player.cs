using Korelskiy.Models.Units;
using Korelskiy.Models.Units.Airplanes.Fighters;
using Korelskiy.Models.Units.Infantry;
using Korelskiy.Models.Units.SupportUnits.Artillery;
using Korelskiy.Models.Units.SupportUnits.Howitzer;
using Korelskiy.Models.Units.SupportUnits.MachineGuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korelskiy.Models
{
    public class Player
    {
        public int ReservePoints { get; set; }
        public string Name { get; }
        public List<BaseUnit> Units { get; set; }

        public Nations Nation { get; }

        public Player(string name, Nations nation)
        {
            Name = name;
            Nation = nation;
            ReservePoints = 100;
            Units = new List<BaseUnit>();
        }

        public List<BaseUnit> GetAvalibleUnits() 
        {
            List<BaseUnit> avalibleUnits = null;
            switch (Nation)
            {
                case Nations.Germany:
                    avalibleUnits = new List<BaseUnit> { new GermanInfantrySquad(), new MG34(), new Leig18(), new Pak36()};
                    break;
                case Nations.Poland:
                    avalibleUnits = new List<BaseUnit> { new PolishInfantrySquad(), new Wz30(), new Wz1897(), new Bofors37() };
                    break;
                default:
                    break;
            }

            return avalibleUnits;
            
        }

        public void BuyUnit(BaseUnit unit)
        {
            Units.Add(unit);
            ReservePoints -= unit.Price;
        }
    }
}
