using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.Serialization;
using System.Xml;

namespace StudentLogic
{
    [DataContract]
    public abstract class Base<T> where T : Base<T>
    {
        private static Dictionary<Guid, T> _items = new Dictionary<Guid, T>();

        [DataMember]
        private Guid _id;

        public Guid Id
        {
            get { return _id; }
            private set { _id = value; }
        }
        public static Dictionary<Guid, T> Items
        {
            get { return _items; }
        }
        public Base()
        {
            Id = Guid.NewGuid();
            _items.Add(Id, (T)this);
        }

        public Base(Guid id)
        {
            _id = id;
            _items.Add(id, (T)this);
        }

        public static void SerializeItems()
        {
            DataContractSerializer dcs = new DataContractSerializer(typeof(Dictionary<Guid, T>));
            XmlWriter xmlw = XmlWriter.Create(@"../../../Data/"+typeof(T).Name + ".xml");
            dcs.WriteObject(xmlw, Items);
            xmlw.Close();
        }

        public static void DeserializeItems()
        {
            if (Items.Count == 0)
            {
                DataContractSerializer dcs = new DataContractSerializer(typeof(Dictionary<Guid, T>));
                XmlReader xmlr = XmlReader.Create(@"../../../Data/" + typeof(T).Name + ".xml");
                Dictionary<Guid, T> dict = (Dictionary<Guid, T>)dcs.ReadObject(xmlr);
                xmlr.Close();
                foreach (var item in dict.Values)
                    Items.Add(item.Id, item);
            }
        }
    }
}
