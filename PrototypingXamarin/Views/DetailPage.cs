using System;

using Xamarin.Forms;

namespace PrototypingXamarin
{
	public class DetailPage : ContentPage
	{
		public DetailPage(Movie movie)
		{
			this.Title = movie.Title;
			var image = new Image
			{
				Source = movie.Image
			};
			var detailText = new Label
			{
				Text = movie.Desc
			};
			Content = new ScrollView
			{
				Padding = 10,
				Content = new StackLayout
				{
					Children = { image, detailText }
				}
			};
		}
	}
}

