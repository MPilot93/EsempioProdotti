using System.IO;

namespace FileHelper
{
    public class Helper
    {

        private readonly string Path;
        public Helper(string path)
        {
            Path = path;
        }
        public void AddContact(listaprodotti list)
        {
            var result = $"{list.id};{list.nome};{list.magazzino}";

            using (var stream = new StreamWriter(Path, true))
            {
                stream.WriteLine(result);
            }
        }

        public List<Contact> ReadAll()
        {
            var nlista = new List<list>();

            using (var stream = new StreamReader(Path))
            {
                var header = "nome;cognome;telefono;indirizzo";

                var firstLine = stream.ReadLine();
                if (!firstLine.Equals(header))
                    throw new Exception("File non conforme!");


                while (!stream.EndOfStream)
                {
                    var row = stream.ReadLine();
                    var splitted = row.Split(";");

                    var list = new list
                    {
                        id = splitted[0],
                        nome = splitted[1],
                        magazzino = splitted[2],
                      
                    };

                    list.Add(list);
                }

                return list;
            }
        }


    }
}