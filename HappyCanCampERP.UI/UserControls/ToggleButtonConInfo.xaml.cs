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
    /// Interaction logic for ToggleButtonConInfo.xaml
    /// </summary>
    public partial class ToggleButtonConInfo: UserControl
    {
        public ToggleButtonConInfo()
        {
            InitializeComponent();
        }

        private static FrameworkPropertyMetadataOptions flags = FrameworkPropertyMetadataOptions.AffectsRender;
        private static FrameworkPropertyMetadataOptions flagsInfo = FrameworkPropertyMetadataOptions.AffectsRender;


        public static readonly DependencyProperty PropiedadText =
                DependencyProperty.Register("TextoDelToggleButton" , typeof(string) , typeof(ToggleButtonConInfo) ,
                        new FrameworkPropertyMetadata(defaultValue: "Texto del ToggleButton" ,
                            propertyChangedCallback: new PropertyChangedCallback(OnTextoDelToggleButtonChanged) ,
                            flags: flags));


        public static readonly DependencyProperty PropiedadTag =
                DependencyProperty.Register("TextoDelInfo" , typeof(string) , typeof(ToggleButtonConInfo) ,
                        new FrameworkPropertyMetadata(defaultValue: "Mas info" ,
                            propertyChangedCallback: new PropertyChangedCallback(OnTextoDelInfoChanged) ,
                            flags: flagsInfo));


        public string TextoDelToggleButton
        {
            get
            {
                return (string)GetValue(PropiedadText);
            }
            set
            {
                SetValue(PropiedadText , value);
            }
        }


        private static void OnTextoDelToggleButtonChanged(DependencyObject d , DependencyPropertyChangedEventArgs e)
        {
            ToggleButtonConInfo target = (ToggleButtonConInfo)d;
            string oldTexto = (string)e.OldValue;
            string newTexto = target.TextoDelToggleButton;
            target.OnTextoDelToggleButtonChanged(oldTexto , newTexto);
        }


        protected virtual void OnTextoDelToggleButtonChanged(string oldTexto , string newTexto)
        {
            TextoDelToggle.Text = newTexto;
        }
        public string TextoDelInfo
        {
            get
            {
                return (string)GetValue(PropiedadTag);
            }
            set
            {
                SetValue(PropiedadTag , value);
            }
        }


        private static void OnTextoDelInfoChanged(DependencyObject d , DependencyPropertyChangedEventArgs e)
        {
            ToggleButtonConInfo targetInfo = (ToggleButtonConInfo)d;
            string oldTextoInfo = (string)e.OldValue;
            string newTextoInfo = targetInfo.TextoDelInfo;
            targetInfo.OnTextoDelInfoChanged(oldTextoInfo , newTextoInfo);
        }


        protected virtual void OnTextoDelInfoChanged(string oldTextoInfo , string newTextoInfo)
        {
            //TextBlockEscondidoParaMostrarTip.Text = newTextoInfo;
            TextBlockInfo.Tag = newTextoInfo;
        }
    }


}
