using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnergyCalculator.Properties;

namespace EnergyCalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppForm = new CalculatorWindow();
            AppForm.AvailableConsumption = 1440;
            AppForm.AllConsumers = LoadConsumers();
            AppForm.PopulateConsumers();
            Application.Run(AppForm);
        }

        public static void StoreState(List<Consumer> consumers)
        {
            PersistentSettings settings = new PersistentSettings {ConsumerList = consumers};
            PersistentFileHandler outFileHandler = new PersistentFileHandler();
            outFileHandler.Save(PersistFilename, settings);
        }

        static List<Consumer> GetConsumerDefaultList()
        {
            List<Consumer> consumers = new List<Consumer>();
            consumers.Add(new Consumer("Projector", 1, 300));
            consumers.Add(new Consumer("Switch", 1, 16));
            consumers.Add(new Consumer("PS4", 1, 150));
            consumers.Add(new Consumer("Lightbulbs", 8, 13));
            consumers.Add(new Consumer("Vive (all)", 1, 11));
            consumers.Add(new Consumer("Ethernet Switch", 1, 5));
            consumers.Add(new Consumer("HDMI Switch", 1, 5));

            return consumers;
        }

        static List<Consumer> LoadConsumers()
        {
            PersistentFileHandler inFileHandler = new PersistentFileHandler();
            PersistentSettings settings = new PersistentSettings();
            settings = inFileHandler.Load(PersistFilename);

            if (settings != null)
            {
                Console.WriteLine("We have file input!");
                return settings.ConsumerList;
            }

            return null;
        }

        static void SaveConsumers()
        {
            
        }

        private static CalculatorWindow AppForm { get; set; }
        private static string PersistFilename = "./settings";
    }
}
