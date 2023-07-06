using MauiCollectionControls.Models;

namespace MauiCollectionControls.Pages;

public partial class CollectionViewDemo : ContentPage
{
	public CollectionViewDemo()
	{
		InitializeComponent();

        collectionView.ItemsSource = GetCountries();
    }

	private List<Country> GetCountries()
	{
		return new List<Country>
		{
            new Country { CountryName = "United States", IsoCode = "USA", FlagUrl = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAD0AAAAgCAMAAACW9ICeAAAAk1BMVEX///+yIjSvBSPdsLT9+vusABSuACDkwMP37e6sABatAB3q0NLx3+CtABk8O24rKmXh4ecxMGg1NGonJmMjImFIR3VaWYFSUXxgX4Wfn7O/v8zLy9Xb2+JlZIiJiaJraozv7/KTk6p0c5MyO2+MLU6yscGAgJyKIUapiZqpqLqulKS7tME5QXOyn662qrgVImOECzxVkGilAAABjklEQVQ4jaWV2XKDMAxF3SXdayEZLzhgglOc0i39/6+r0vaxgGZ6hvvAgwfJV1wpTaT/0P7pTIDCZkQcIlLZIuUWqWuJXLU/XJ2vo3QIZEOH3vXgPcvmbz1fCFCazLQ1pmGlykCpAPodIkQlgbqsdSiafPqRTVrbhFFdrqOomQCG0UAaAXLkL28BXIuHjQCuHNJkTOGzfQTTRTQhEuwPd1fr8GmdC+q+gO4SaDeA9ix8uRagcOKqG642sXLLFVQIYWdkt6a958eT894E68D96vVGwMmxMf44NrTcfwUm75D73tyuo6gkrngA6BquuCHjJl276e3weLeOojQAFlZuuOcJ0I2ANh7f7wWcHBvYrcRO5+3Jba6gJRDOGjvW9fQWMljH8gWsZcHHgwCFI3+VHcOh5Q4q7oCnPOz41h7XUTViXSPUNf3q+52On6LT1QySwh9EdzOPxJh5xwQzsTAtgnlcmFTJzzD/l/wPSQjMp4MgfxaSSRJ+86koyN2FRP4fkoUzv4kEu25hC0oW7SxfIZ1HhsoG8VoAAAAASUVORK5CYII=" },
            new Country { CountryName = "Canada", IsoCode = "CAN", FlagUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTftmA2NVkJA2CXXEXGtT74Te8DvY6rLn6bFoeTMyHnaDXPu2MXyFe8og&s=0" },
            new Country { CountryName = "United Kingdom", IsoCode = "GBR", FlagUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQumAe3qPG1JiZvhsoaDgRQ8mUPhJ3FH71Fob_7j4UEYqBnjKOVNSdQiQ&s=0" },
            new Country { CountryName = "Germany", IsoCode = "DEU", FlagUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_RTiW6ZrAu6g2shDW1r6GvBvRypvpmtAY5BZI8LQdDjN7iKadlkbuDA&s=0" },
            new Country { CountryName = "Australia", IsoCode = "AUS", FlagUrl = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAADwAAAAeCAMAAABHRo19AAAAnFBMVEUAAIv/AAD///8AAIoAAIb/raqeptAAAIH/RUQAAJH/2dj5////ra33+///qaiIib6IlMf3tLr/Hg//JhqZoc0xMZjz8/mFhb1DQ552drcYGJD/GASmrdT/tayjo8vl5fHIyOEpKZT/U1Htrbf/KCb/3ddSUqWBjsbxqrPP1uv/Niza2uyMm8sPD420tNhNTaT/X0xoaK5fX6q9vdpGU4gGAAABrUlEQVQ4jbWU63aCMAyAaROtqCiogDjlolNBRaa+/7uNci9ad+Sc5Q+lyZe0SRplO6SWjaikgv0eIb1+vlaOu+/tPlvLZTcfDKk25XgNo6IbfH/E3sOp2SzDGZYwwsUoXAqWkIrIQm3KFhxeYO1OsAXzcDBFOvWGcAy5uRVNCJlE4YmvbcZagWBJ6VKEKZfRKPvQMSFj2txp3hlsTbNFmLwVtWmKjtPK/gewgu3KfQKXWepw50ocXFV+gDHbosPBKcyzzdezUE+LUMVopgldeq72kU211PzL0DGvc/4/My5Q1DlGB+Pq0PGVeklBY2Y656ZVh1XuchPm00d9fljadpk4K0N1Rezt0iWPAEFEo6A+OdSNt98WaIqsN4Rs1vma4/ufLNt4c25lLLHpUFGh1CCojR/GUG3HAsdpvY0PBH1f/sTbb+5JL5ZN0ECSFuEtL1OCicx1GQZdbgUry/U811p1SgneeTvf/xh6ssgPDj+kkZ9nWK2Kr75Hqedf49cmYCaJKaWR+Zblt8ZeQ/88w5rCzkFwll75xQwTDwYgPdirGSbS8i7I6E6F+A/5BZ7EGtYAOlCkAAAAAElFTkSuQmCC" },
            new Country { CountryName = "France", IsoCode = "FRA", FlagUrl = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAADwAAAAoCAMAAACVZWnNAAAAFVBMVEX///8AJlTOESYAJVMAGE3NABjODiVwVyeBAAAAKUlEQVRIie3LqQEAMAwEoOu7/8gZIFXV4Mlo1s7DubOJLMuyLMuy/JsLZ4sLQVXY+QAAAAAASUVORK5CYII=" },
            new Country { CountryName = "Italy", IsoCode = "ITA", FlagUrl = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAADwAAAAoCAMAAACVZWnNAAAAFVBMVEX///8AkkbOKzcAkkUAjz7NHy3OKjYFAN/lAAAAKUlEQVRIie3LqQEAMAwEoOu7/8gZIFXV4Mlo1s7DubOJLMuyLMuy/JsLZ4sLQVXY+QAAAAAASUVORK5CYII=" },
            new Country { CountryName = "Sweden", IsoCode = "SWE", FlagUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQARa7WI7vq1wgQrblycxgwNK_4ZtBRMGDKQBJdDlyEU8sE0K3B3UnCIA&s=0"}
        };
	}
}