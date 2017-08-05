using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace EnergyCalculator
{
    [DataContract]
    public class PersistentSettings
    {
        public PersistentSettings()
        {
            ConsumerList = new List<Consumer>();
        }

        [DataMember]
        public List<Consumer> ConsumerList { get; set; }
    }

    public class PersistentFileHandler
    {
        public PersistentFileHandler()
        {
        }

        protected StreamReader Reader { get; set; }
        protected StreamWriter Writer { get; set; }

        public PersistentSettings Load(string filename)
        {
            PersistentSettings settings = null;
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(PersistentSettings), new Type[] { typeof(PersistentSettings) });

            if (OpenReader(filename))
            {
                try
                {
                    settings = serializer.ReadObject(Reader.BaseStream) as PersistentSettings;
                    Reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                //settings = serializer.ReadObject(Reader.BaseStream) as PersistentSettings;
                //Reader.Close();
            }

            return settings;
        }

        public bool Save(string filename, PersistentSettings setting)
        {
            bool success = false;
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(PersistentSettings), new Type[] { typeof(PersistentSettings) });

            if (OpenWriter(filename))
            {
                serializer.WriteObject(Writer.BaseStream, setting);
                Writer.Close();
                success = true;
            }

            return success;
        }

        protected virtual bool OpenReader(string filename)
        {
            bool result = false;
            try
            {
                Reader = new StreamReader(filename);
                result = true;
            }
            catch (Exception err)
            {
                Console.WriteLine($"Cannot open input file {filename}, error={err}");
            }

            return result;
        }


        protected virtual bool OpenWriter(string filename)
        {
            bool result = false;
            try
            {
                if (Directory.Exists(Path.GetDirectoryName(filename)))
                {
                    Writer = new StreamWriter(filename);
                    result = true;
                }
            }
            catch (Exception err)
            {
                Console.WriteLine($"Cannot open output file {filename}, error={err}");
            }

            return result;
        }
    }
}

