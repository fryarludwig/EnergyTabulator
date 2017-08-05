using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnergyCalculator
{
    public partial class CalculatorWindow : Form
    {
        public CalculatorWindow()
        {
            InitializeComponent();
            AllConsumers = new List<Consumer>();
            ConsumerForms = new List<ConsumerSelection>();
        }

        public void PopulateConsumers()
        {
            ConsumerTable.Controls.Clear();
            ConsumerTable.RowStyles.Clear();

            foreach (Consumer consumer in AllConsumers)
            {
                ConsumerSelection form = new ConsumerSelection(consumer, this);
                ConsumerForms.Add(form);
                ConsumerTable.Controls.Add(form);

                Console.WriteLine($"Added {consumer.Name}");
            }
            
            UpdateConsumption();
        }

        public void UpdateConsumption()
        {
            int total = 0;
            foreach (ConsumerSelection form in ConsumerForms)
            {
                total += form.Consumption;
            }

            TotalConsumption.Text = $"{total} / {AvailableConsumption}";
            TotalConsumption.ForeColor = (total > AvailableConsumption) ? Color.DarkRed : Color.Black;
            Program.StoreState(AllConsumers);
        }
        
        private void OnAddConsumerClicked(object sender, EventArgs e)
        {
            string newName = AddNameInput.Text;
            int newCount = (int)AddCountInput.Value;
            int newWatts = (int)AddWattsInput.Value;
            Consumer newConsumer = new Consumer(newName, newCount, newWatts);
            AllConsumers.Add(newConsumer);
            ConsumerSelection newForm = new ConsumerSelection(newConsumer, this);
            ConsumerForms.Add(newForm);
            ConsumerTable.Controls.Add(newForm);
            UpdateConsumption();
        }

        public List<ConsumerSelection> ConsumerForms { get; set; }
        public List<Consumer> AllConsumers { get; set; }
        public int AvailableConsumption { get; set; }
        public Delegate UpdateTotal { get; set; }
    }
}
