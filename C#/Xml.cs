[XmlRoot("JDF", Namespace = "http://www.CIP4.org/JDFSchema_1_1")]
    public class Jdf
    {
				/// <summary> SERVER </summary>
        [XmlAttribute("SERVER", Namespace = "http://www.jspirits.co.jp/JDF/JDFschema_1_0")]
        public string Server { get; set; }
		}


var xmlns = new XmlSerializerNamespaces();
xmlns.Add("jsp", "http://www.jspirits.co.jp/JDF/JDFschema_1_0");
Goof.Com.Serializer.ToXmlFile(filePath, Model , xmlns);