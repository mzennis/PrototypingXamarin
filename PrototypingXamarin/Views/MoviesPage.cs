using System;

using Xamarin.Forms;

namespace PrototypingXamarin
{
	public class MoviesPage : ContentPage
	{
		public MoviesPage()
		{
			NavigationPage.SetHasNavigationBar(this, true);
			Title = "Movies";
			var viewmodel = new MovieViewModel();
			var list = new ListView();
			list.ItemsSource = viewmodel.Movies;
			var cell = new DataTemplate(typeof(ImageCell));
			cell.SetBinding(ImageCell.ImageSourceProperty, "Image");
			cell.SetBinding(ImageCell.TextProperty, "Title");
			cell.SetBinding(ImageCell.DetailProperty, "Desc");
			list.ItemTemplate = cell;
			list.ItemTapped += (sender, args) =>
			{
				var city = args.Item as Movie;
				if (city == null)
					return;
				Navigation.PushAsync(new DetailPage(city));
				list.SelectedItem = null;
			};
			Content = list;
		}
	}
}

