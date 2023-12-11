
/*   

*      Dokumentacja pomocna do naszej dzisiejszej lekcji:

*      https://learn.microsoft.com/pl-pl/dotnet/api/system.io?view=net-7.0

*/

using System;

using System.IO;    // Wymagana przestrzeń nazwy, by móc operować plikami
 
namespace TE_LOD_DesktopFiles

{

    public class Program

    {

        public static void Main(string[] args)

        {

            // Obejmij kod obsługą błędów

            try

            {
                Console.WriteLine("podaj lokalizajce pliku");
                string path = Console.ReadLine();

                if (File.Exists(path))
                {
                    Console.WriteLine(File.ReadAllText(path));
                }
                else
                {
                    Console.WriteLine("Nie ma plików");
                    File.Create(path).Close();

                    Console.WriteLine("Podaj zawartość tego pliku");

                    string data = Console.ReadLine();
                    string text = "";
                    while (data != ("END;;")){
                        text += data + "\n";
                        data = Console.ReadLine();
                    }
                    File.WriteAllText(path, text);
                }

            }

            catch (IOException ex)

            {

                Console.WriteLine(ex.Message);

            }

        }

    }

}

/* Pomoc do zajęć:

*      - Klasa File, Directory, Path

*      - Operacje na plikach (czy istnieje, odczyt, zapis, przenieś, usuń)

*      - Operacje na katalogach (czy istnieje, stwórz, usuń, lista wszystkich plików oraz katalogów)

*      - Operacje na strumieniach (StreamReader, StreamWriter)

*/
