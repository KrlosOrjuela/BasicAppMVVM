using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using FirstApp.Interfaces;
using FirstApp.Models;
using Newtonsoft.Json;

namespace FirstApp.Services
{
	public class OffLineDataService: IOffLineDataService
	{
		public OffLineDataService()
		{
		}

        public List<Section> GetMockSections()
        {
            string jsonFileName = "Mock_Sections.json";
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.MockData.{jsonFileName}");
            var sections = new List<Section>();

            using (var reader = new StreamReader(stream))
            {
                var jsonString = reader.ReadToEnd();
                sections = JsonConvert.DeserializeObject<List<Section>>(jsonString);
            }

            return sections;
        }
    }
}

