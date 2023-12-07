using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReDoMusic.Persistence.Contexts;
using ReDoMusic.Domain;

namespace ReDoMusic.Persistence
{
    public static class Configurations
    {
        public static string GetString(string key)
        {
            ConfigurationManager configurationManager = new();

            string path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\ReDoMusic\\Infrastructure\\.Persistence";

            configurationManager.SetBasePath(path);
            configurationManager.AddJsonFile("Private_Informations.json");
            return configurationManager.GetSection(key).Value;
        }
    }
}
