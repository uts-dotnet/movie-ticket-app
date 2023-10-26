using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MovieTicketApp.src.Managers
{
    public class FileManager<T>
    {
        private string filePath;

        public FileManager(string filePath)
        {
            this.filePath = filePath;
        }

        public List<T> Load()
        {
            if (File.Exists(filePath))
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                    List<T> data = (List<T>)serializer.Deserialize(fileStream);
                    return data;
                }
            }
            return new List<T>();
        }

        public void Save(List<T> data)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                serializer.Serialize(fileStream, data);
            }
        }
    }

