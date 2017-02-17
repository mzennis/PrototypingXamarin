using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace PrototypingXamarin
{
	public class MovieViewModel
	{
		public ObservableCollection<Movie> Movies;
		public MovieViewModel()
		{
			Movies = new ObservableCollection<Movie>();
			Movies.Add( new Movie {
				Title = "Despicable Me 2",
				Desc = "Now that Gru (Steve Carell) has forsaken a life of crime to raise Margo, Agnes and Edith, he's trying to figure out how to provide for his new family.",
				Image = "despicable2.jpg"
			});
			Movies.Add(new Movie
			{
				Title = "Cloudy with a Chance of Meatballs",
				Desc = "Columbia Pictures' and Sony Pictures Animation's \"Cloudy with a Chance of Meatballs\" will be the most delicious event since macaroni met cheese",
				Image = "cloudy.jpg"
			});
			Movies.Add(new Movie
			{
				Title = "Megamind",
				Desc = "The supervillain Megamind finally defeats his nemesis, the superhero Metro Man. But without a hero, he loses all purpose and must find new meaning to his life.",
				Image = "megamind.jpg"
			});
			Movies.Add(new Movie
			{
				Title = "Kungfu Panda",
				Desc = "The Dragon Warrior has to clash against the savage Tai Lung as China's fate hangs in the balance: However, the Dragon Warrior mantle is supposedly mistaken to be bestowed upon an obese panda who is a tyro in martial arts.",
				Image = "kungfupanda.jpg"
			});
			Movies.Add(new Movie
			{
				Title = "Shrek",
				Desc = "After his swamp is filled with magical creatures, Shrek agrees to rescue Princess Fiona for a villainous lord in order to get his land back.",
				Image = "shrek.jpg"
			});
			Movies.Add(new Movie
			{
				Title = "The Incridibles",
				Desc = "A family of undercover superheroes, while trying to live the quiet suburban life, are forced into action to save the world.",
				Image = "incridibles.jpg"
			});
			Movies.Add(new Movie
			{
				Title = "Ratatouille",
				Desc = "A rat who can cook makes an unusual alliance with a young kitchen worker at a famous restaurant.",
				Image = "ratatouli.jpg"
			});
		}
	}
}
