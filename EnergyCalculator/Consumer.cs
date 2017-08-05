using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EnergyCalculator
{
    [DataContract]
    public class Consumer
    {
        public Consumer(string name = "", int count = 0, int wattage = 0)
        {
            Name = name;
            Count = count;
            Wattage = wattage;
        }

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Count { get; set; }
        [DataMember]
        public int Wattage { get; set; }
        public int TotalConsumption => Wattage * Count;
    }
}
