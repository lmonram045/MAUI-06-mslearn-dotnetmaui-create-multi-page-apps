using Astronomy.Pages;

namespace Astronomy;

// Clase AppShell que hereda de Shell
 public partial class AppShell : Shell
 {
     // Método constructor de la clase AppShell
     public AppShell()
     {
         // Inicializa los componentes del diseño visual
         InitializeComponent();
         
         // Método que registra una ruta específica y asocia un tipo de página a esa ruta
         // En este caso, estamos asociando "astronomicalbodydetails" con la página AstronomicalBodyPage
         Routing.RegisterRoute("astronomicalbodydetails", typeof(AstronomicalBodyPage));
     }
 }
