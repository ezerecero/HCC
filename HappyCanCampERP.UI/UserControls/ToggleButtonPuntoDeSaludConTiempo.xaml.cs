using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HappyCanCampERP.UI.UserControls
{
    /// <summary>
    /// Interaction logic for EstadoDePuntoDeSaludConTiempo.xaml
    /// </summary>
    public partial class ToggleButtonPuntoDeSaludConTiempo : UserControl
    {
        public ToggleButtonPuntoDeSaludConTiempo()
        {
            InitializeComponent();
        }

        private static FrameworkPropertyMetadataOptions flags = FrameworkPropertyMetadataOptions.AffectsRender;

        /// <summary>
		/// Letter Dependency Property
		/// </summary>
		public static readonly DependencyProperty TextProperty =
                DependencyProperty.Register("Texto", typeof(string), typeof(ToggleButtonPuntoDeSaludConTiempo),
                        new FrameworkPropertyMetadata(defaultValue: "Estado de un punto",
                            propertyChangedCallback: new PropertyChangedCallback(OnTextoChanged),
                            flags: flags));

        /// <summary>
        /// Gets or sets the Letter property. This dependency property
        /// indicates what character to show.
        /// </summary>
        public string Texto
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        /// <summary>
        /// Handles changes to the Letter property.
        /// </summary>
        private static void OnTextoChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ToggleButtonPuntoDeSaludConTiempo target = (ToggleButtonPuntoDeSaludConTiempo)d;
            string oldTexto = (string)e.OldValue;
            string newTexto = target.Texto;
            target.OnTextoChanged(oldTexto, newTexto);
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the Letter property.
        /// </summary>
        protected virtual void OnTextoChanged(string oldTexto, string newTexto)
        {

            TextoDelToggleButton.Text = newTexto;
            
        }

    }
}
