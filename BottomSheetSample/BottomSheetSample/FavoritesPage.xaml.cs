using BottomSheetSample;

namespace BottomSheet;

public partial class FavoritesPage : ContentPage
{
    public List<Book> FavoriteBooks { get; set; }
    public FavoritesPage()
	{
		InitializeComponent();
        FavoriteBooks = BookFavorites.FavoriteBooks;
        BindingContext = this;
    }
}