namespace Astronomy.Pages;

// Clase AstronomicalBodiesPage que hereda de la clase ContentPage
// Es un ejemplo de como pasar informacion entre paginas
public partial class AstronomicalBodiesPage : ContentPage
{
    // Constructor de la clase AstronomicalBodiesPage
	public AstronomicalBodiesPage()
	{
        // Inicializa los componentes de la interfaz gráfica
		InitializeComponent();

        // Asigna un manejador de eventos al botón btnComet que, al hacer click, navega a la página
        // "astronomicalbodydetails" y añade un parámetro llamado "astroName" con valor "comet"
		btnComet.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=comet");
		
        // Asigna un manejador de eventos al botón btnEarth que, al hacer click, navega a la página 
        // "astronomicalbodydetails" y añade un parámetro llamado "astroName" con valor "earth"
		btnEarth.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=earth");
		
        // Asigna un manejador de eventos al botón btnMoon que, al hacer click, navega a la página
        // "astronomicalbodydetails" y añade un parámetro llamado "astroName" con valor "moon"
		btnMoon.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=moon");
		
        // Asigna un manejador de eventos al botón btnSun que, al hacer click, navega a la página
        // "astronomicalbodydetails" y añade un parámetro llamado "astroName" con valor "sun"
		btnSun.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=sun");
	}
}