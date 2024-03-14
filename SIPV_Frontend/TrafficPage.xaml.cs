using System.Collections.ObjectModel;

namespace SIPV_Frontend.Views;

public partial class TrafficPage : ContentPage
{
	ObservableCollection<TrafficNews> list_novic = new ObservableCollection<TrafficNews>();
	public TrafficPage()
	{
		InitializeComponent();
		list_novic.Add(new TrafficNews("Zastoj", "Na stajerski avtocesti je oviran promet med prikljuckoma Domzale in Krtina proti Mariboru. Nastal je zastoj, zamuda do 5 minut.", "https://pomocnik.meblosignalizacija.si/images/prometni-zastoj-1123-144.png", new DateTime(2024,3,14,16,39,02)));
        list_novic.Add(new TrafficNews("Delo na cesti", "Na primorski avtocesti bo zaprt vozni pas med Uncem in Logatcem proti Ljubljani od sobote, od 6. ure, do nedelje predvidoma do 16. ure.", "https://www.lorencic.si/0cache/930aa4f2bc49b4b4c108273459b7a5a2.jpg", new DateTime(2024, 3, 13, 14, 22, 34)));
        list_novic.Add(new TrafficNews("Zastoj", "Na stajerski avtocesti pred predorom Podmilj ter med Krtino in Domzalami proti Ljubljani, skupaj zamuda 5 - 10 minut.", "https://pomocnik.meblosignalizacija.si/images/prometni-zastoj-1123-144.png", new DateTime(2024, 3, 12, 11, 14, 31)));
        list_novic.Add(new TrafficNews("Nesreca", "Na cesti Murska Sobota - Beltinci je zaprt odsek RakiCan - Lipovci.", "https://pomocnik.meblosignalizacija.si/images/prometna-nesreca-1124-144.png", new DateTime(2024, 3, 10, 17, 29, 33)));
        list_novic.Add(new TrafficNews("Delo na cesti", "Stajerska avtocesta bo zaprta med Vranskim in Blagovico proti Ljubljani od petka, 15. 3., od 21. ure, do nedelje, 17. 3., predvidoma do 15. ure. Zaprt bo tudi uvoz Trojane v obe smeri. Obvoz bo po regionalni cesti.", "https://www.lorencic.si/0cache/930aa4f2bc49b4b4c108273459b7a5a2.jpg", new DateTime(2024, 3, 10, 8, 12, 24)));

        news_collection.ItemsSource = list_novic;
	}
}