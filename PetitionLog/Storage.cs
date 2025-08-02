using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace PetitionLog
{
    internal class Storage
    {
        private static readonly string FolderPath = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
        "Petition Log" );

        private static readonly string FilePath = Path.Combine(FolderPath, "petitions.json");

        public static SortableBindingList<Petition> Load()
        {
            if (!Directory.Exists(FolderPath))
                Directory.CreateDirectory(FolderPath);

            if (!File.Exists(FilePath))
                return new SortableBindingList<Petition>();

            string json = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<SortableBindingList<Petition>>(json);
        }

        public static void Save(SortableBindingList<Petition> petitions)
        {
            if (!Directory.Exists(FolderPath))
                Directory.CreateDirectory(FolderPath);

            string json = JsonConvert.SerializeObject(petitions, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        public static void Purge(int daysThreshold)
        {
            // Load existing petitions
            var petitions = Load();

            var now = DateTime.Now;

            // Filter out old entries
            var filteredPetitions = petitions
                .Where(petition => (now - petition.DateAdded).TotalDays <= daysThreshold)
                .ToList();

            // Create new SortableBindingList with filtered data
            var updatedPetitions = new SortableBindingList<Petition>();
            foreach (var petition in filteredPetitions)
            {
                updatedPetitions.Add(petition);
            }

            // Save the updated list
            Save(updatedPetitions);
        }
    }
}
