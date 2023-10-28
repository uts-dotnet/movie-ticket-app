﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using MovieTicketApp.src.Managers;
using MovieTicketApp;

/* EXAMPLE OF HOW TO USE:

//Create FileManager instances for data type
FileManager<Movie> movieFileManager = new FileManager<Movie>("movies.txt");

// Load data into lists, skipping headers
List<Movie> movies = movieFileManager.Load().Skip(1).ToList();

// Now you can work with the loaded data, and headers have been skipped
foreach (var movie in movies)
{
    Console.WriteLine($"Movie Title: {movie.Title}");
}

*/

namespace MovieTicketApp.src.Managers
{
    public class FileManager<T>
    {
        private string filePath;

        public FileManager(string filePath)
        {
            this.filePath = filePath;
        }

        public List<T> Load(bool skipHeaders = true)
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);

                // Skip headers if skipHeaders is true
                if (skipHeaders && lines.Length > 0)
                {
                    lines = lines.Skip(1).ToArray();
                }

                using (var fileStream = new FileStream(filePath, FileMode.Open))
                {
                    var serializer = new XmlSerializer(typeof(List<T>));
                    var data = (List<T>)serializer.Deserialize(fileStream);
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
}
