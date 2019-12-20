using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace io.samples.serialization {
    [Serializable]
    public class SerializableObject {
        // public setter is required for de-serialization
        public string Name { get; set; }
        public int Age { get; set; }

        //  parameterless construnctor is required for serialization
        public SerializableObject() { }

        public SerializableObject(string name, int age) {
            this.Name = name;
            this.Age = age;
        }
    }

    public class SerializationTest {
        public SerializationTest() {
            XmlSerializer xs = new XmlSerializer(typeof(SerializableObject));
            var obj = new SerializableObject("reke", 1);
            var xml = "";
            using(var sw = new StringWriter()) {
                using(XmlWriter xw = XmlWriter.Create(sw)) {
                    xs.Serialize(xw, obj);
                    xml = sw.ToString();
                    Console.WriteLine(xml);
                }
            }
        }
    }
}