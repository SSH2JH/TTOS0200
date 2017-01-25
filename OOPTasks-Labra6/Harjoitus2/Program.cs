/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: OOP Labra 6 - Tehtävä 2
 * Kuvaus:
 *		 Aikaisemmissa demoissa tehtiin CD-luokka, joka sisälsi CD:lle yleisesti kuuluvia ominaisuuksia.
 *		 Muuta/tee toteutus, jossa CD:n sisällä olevien biisien määrää ei ole rajattu.
 *		 Käsittele CD:n osalta ainakin seuraavat tiedot: nimi, artisti ja biisit.
 *		 Ohjelmoi suunnittelemasi CD-luokka. Toteuta pääohjelmassa CD-olio. Tiedot voit keksiä itse,
 *		 niitä ei tarvitse kysyä käyttäjältä. Tulosta ruudulle CD:n tietoja. 
 * Pvm: 25.1.2017
 */

using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace OOP.Tasks {
	class Program {
		static void Main(string[] args)
		{
			MusicPlayerTester();
		}
		static void MusicPlayerTester()
		{
			MusicDisk disk1 = new MusicDisk();
			disk1.AlbumName = "Resistance";
			disk1.ArtistName = "Muse";
			disk1.AlbumGenre = "Rock";

			Song IsolatedSystem = new Song { SongName = "Isolated System", LenghtSeconds = 270};
			Song Unsustainable = new Song { SongName = "Unsustainable", LenghtSeconds = 300 };

			Console.WriteLine(disk1.AddSong(IsolatedSystem));
			Console.WriteLine(disk1.AddSong(Unsustainable));
		}
	}
}
