using System;
using System.Collections.Generic;
using username;
using System.ComponentModel.DataAnnotations;

namespace thechurches
{



    public class Church
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Denomination { get; set; }

        public Church(string name, string location, string denomination)
        {
            Name = name;
            Location = location;
            Denomination = denomination;
        }
    }

    class churches
    {
        static void Main(string[] args)
        {
            {
                string username;
                string password;

                Console.WriteLine(" LIST OF CHURCHES IN LUZON LOGIN");
                Console.WriteLine();


                Console.WriteLine("Enter Username: ");
                username = Console.ReadLine();


                Console.WriteLine("Enter Password: ");
                password = Console.ReadLine();

                bool result = un.Login(username, password);


                if (result)
                {
                    Console.WriteLine("Successfully Login!");
                    DisplayChurches();
                }

                else
                {
                    Console.WriteLine("There's an error! Try again.");
                }

            }
            static void DisplayChurches()
            {

                List<Church> luzonChurches = new List<Church>();

                luzonChurches.Add(new Church("MANILA CATHEDRAL", "Manila", "Roman Catholic"));
                luzonChurches.Add(new Church("ST. PAUL METROPOLITAN CATHEDRAL", "Vigan", "Roman Catholic"));
                luzonChurches.Add(new Church("BAGUIO CATHEDRAL", "Baguio", "Roman Catholic"));
                luzonChurches.Add(new Church("BASILICA MINORE DE SAN MARTIN DE TOURS", "Taal, Batangas", "Roman Catholic"));
                luzonChurches.Add(new Church("ST. JOHN THE BAPTIST CHURCH", "Calamba", "Roman Catholic"));
                luzonChurches.Add(new Church("CHRIST THE KING PARISH", "Quezon City", "Roman Catholic"));
                luzonChurches.Add(new Church("QUIAPO CHURCH", "Quiapo Manila", "Roman Catholic"));
                luzonChurches.Add(new Church("SAN AUGUSTIN CHURCH", "Intramuros Manila", "Roman Catholic"));
                luzonChurches.Add(new Church("PAOAY CHURCH", "Paoay, Ilocos Norte", "Roman Catholic"));
                luzonChurches.Add(new Church("ST. WILLIAM'S CATHEDRAL", "Laog City", "Roman Catholic"));
                luzonChurches.Add(new Church("IGLESIA NI CRISTO CENTRAL TEMPLE", "Quezon City, Metro Manila", "Roman Catholic"));
                luzonChurches.Add(new Church("ASSUMPTION OF OUR LADY", "Dauis", "Roman Catholic"));
                luzonChurches.Add(new Church("DIOCESE OF TARLAC", "Tarlac City, Metro Manila", "Roman Catholic"));
                luzonChurches.Add(new Church("IMMACULATE CONCEPTION", "Olangapo City, Metro Manila", "Roman Catholic"));
                luzonChurches.Add(new Church("HOLY CROSS", "Toledo City, Metro Manila", "Roman Catholic"));
                luzonChurches.Add(new Church("OUR LADY OF FATIMA", "General Mamerto, Natividad", "Roman Catholic"));
                luzonChurches.Add(new Church("OUR LADY OF PILAR", "Zaragoza", "Roman Catholic"));
                luzonChurches.Add(new Church("OUR LADY OF REMEDIES", "Bulacan", "Roman Catholic"));
                luzonChurches.Add(new Church("OUR LADY OF MOST HOLY ROSARY","Bulacan", "Roman Catholic"));
                luzonChurches.Add(new Church("SACRED HEART", "Bulacan", "Roman Catholic"));
                luzonChurches.Add(new Church("SAN LORENZO RUIZ QUASI-PARISH", "Bulacan", "Roman Catholic"));
                luzonChurches.Add(new Church("ST. MOTHER TERESA OF CALCUTTA PARISH", "Binan City, Laguna", "Roman Catholic"));
                luzonChurches.Add(new Church("DIOCESAN SHRINE OF SAN ISIDRO LABRADOR DE BINAN", "Binan City, Laguna", "Roman Catholic"));
                luzonChurches.Add(new Church("CALERUEGA CHURCH", "Batangas", "Roman Catholic"));
                luzonChurches.Add(new Church("OUR LADY OF MANAOAG AT TIERRA DE MARIA", "Tagaytay", "Roman Catholic"));
                luzonChurches.Add(new Church("SAINT PADRE PIO PARISH AND SHRINE", "Batangas", "Roman Catholic"));
                luzonChurches.Add(new Church("BAROSOAIN CHURCH", "Malolos Bulacan", "Roman Catholic"));
                luzonChurches.Add(new Church("THE EPISCOPAL CHURCH OF SAINT MARY THE VIRGIN", "Sagada", "Roman Catholic"));
                luzonChurches.Add(new Church("MONASTERIO DE SANTA CLARA", "Quezon City", "Roman Catholic"));
                luzonChurches.Add(new Church("BALER CATHOLIC CHURCH", "Baler", "Roman Catholic"));
                luzonChurches.Add(new Church("NATIONAL SHRINE OF THE DIVINE MERCY", "Marilao", "Roman Catholic"));

                Console.WriteLine("List of Churches in Luzon:\n");
                foreach (Church church in luzonChurches)
                {
                    Console.WriteLine($"Name: {church.Name}");
                    Console.WriteLine($"Location: {church.Location}");
                    Console.WriteLine($"Denomination: {church.Denomination}");
                    Console.WriteLine();
                }
            }
        }
    }
}

