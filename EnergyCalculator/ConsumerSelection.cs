using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using EnergyCalculator;
//using EnergyCalculator.Consumer;

namespace EnergyCalculator
{
    public partial class ConsumerSelection : UserControl
    {
        public ConsumerSelection(Consumer consumer, CalculatorWindow parent)
        {
            InitializeComponent();
            MyConsumer = consumer;
            IsSelected.Checked = true;
            NameLabel.Text = MyConsumer.Name;
            ConsumerCount.Value = MyConsumer.Count;
            WattsInput.Value = MyConsumer.Wattage;
            TotalUsage.Text = (MyConsumer.Wattage * ConsumerCount.Value).ToString();
            Parent = parent;
        }

        private void OnCountChanged(object sender, EventArgs e)
        {
            MyConsumer.Count = (int)ConsumerCount.Value;
            TotalUsage.Text = (MyConsumer.Wattage * ConsumerCount.Value).ToString();
            UpdateControl();
        }

        private void OnWattsChanged(object sender, EventArgs e)
        {
            MyConsumer.Wattage = (int)WattsInput.Value;
            UpdateControl();
        }

        private void OnSelectChanged(object sender, EventArgs e)
        {
            UpdateControl();
        }

        private void OnDoubleClicked(object sender, EventArgs e)
        {
            IsSelected.Checked = !IsSelected.Checked;
            UpdateControl();
        }

        private void UpdateControl()
        {
            NameLabel.ForeColor = IsSelected.Checked ? Color.Black : Color.LightSlateGray;
            TotalUsage.Text = (MyConsumer.Wattage * ConsumerCount.Value).ToString();
            Parent?.UpdateConsumption();
        }

        public int Consumption => IsSelected.Checked ? (int)(MyConsumer.Wattage * ConsumerCount.Value): 0;
        public bool IsUsed => IsSelected.Checked;
        public Consumer MyConsumer { get; set; }
        public CalculatorWindow Parent;

    }
}
