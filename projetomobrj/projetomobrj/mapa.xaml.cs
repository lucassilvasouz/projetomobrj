using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace projetomobrj
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class mapa : ContentPage
    {
        string _cepInformado;
        public mapa(string cepInformado)
        {
            InitializeComponent();
            _cepInformado = cepInformado;

            Position position = new Position(36.9628066, -122.0194722);
            MapSpan mapSpan = new MapSpan(position, 0.01, 0.01);
            //MapSpan mapSpan = MapSpan.FromCenterAndRadius(position, Distance.FromKilometers(0.444));

            Map map = new Map(mapSpan);

            Content = new StackLayout
            {
                Margin = new Thickness(10),
                Children = { map }
            };


        }

        public MapType MapType { get; }
    }
}