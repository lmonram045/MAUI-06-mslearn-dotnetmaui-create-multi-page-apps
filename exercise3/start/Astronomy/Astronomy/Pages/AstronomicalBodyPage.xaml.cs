namespace Astronomy.Pages;
// Se usa el atributo QueryProperty para mapear "astroName" a la Propiedad AstroName
 [QueryProperty(nameof(AstroName), "astroName")]
 public partial class AstronomicalBodyPage : ContentPage
 {
     string astroName;
     // Definición de la propiedad AstroName con un setter personalizado
     public string AstroName
     {
         get => astroName;
         set
         {
             astroName = value;
             // En custom function para actualizar la UI inmediatamente
             UpdateAstroBodyUI(astroName); 
         } 
     }
 
     // Constructor para la clase AstronomicalBodyPage
     public AstronomicalBodyPage()
     {
         // Inicaliza los componentes de la interfaz gráfica
         InitializeComponent();
     }
 
     // Método para actualizar la interface de usuario en base al nombre del cuerpo astronómico
     void UpdateAstroBodyUI(string astroName)
     {
         // Obtiene los datos del cuerpo astronómico en base al nombre
         AstronomicalBody body = FindAstroData(astroName);
 
         // Actualiza la interfaz de usuario en base al cuerpo astronómico
         Title = body.Name;
         lblIcon.Text = body.EmojiIcon;
         lblName.Text = body.Name;
         lblMass.Text = body.Mass;
         lblCircumference.Text = body.Circumference;
         lblAge.Text = body.Age;
     }
 
     // Método para obtener los datos del cuerpo astronómico a partir del nombre
     AstronomicalBody FindAstroData(string astronomicalBodyName)
     {
         // Retorna los datos en función del nombre del cuerpo astronómico
         return astronomicalBodyName switch
         {
             "comet" => SolarSystemData.HalleysComet,
             "earth" => SolarSystemData.Earth,
             "moon" => SolarSystemData.Moon,
             "sun" => SolarSystemData.Sun,
             // Lanza una excepción si el nombre no coincide con ningún caso
             _ => throw new ArgumentException()
         };
     }
 }