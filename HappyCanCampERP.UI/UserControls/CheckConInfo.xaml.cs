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
    /// Interaction logic for CheckConInfo.xaml
    /// </summary>
    public partial class CheckConInfo: UserControl
    {
        public CheckConInfo()
        {
            InitializeComponent();
        }

        private static FrameworkPropertyMetadataOptions flags = FrameworkPropertyMetadataOptions.AffectsRender;
        private static FrameworkPropertyMetadataOptions flagsInfo = FrameworkPropertyMetadataOptions.AffectsRender;


        public static readonly DependencyProperty PropiedadText =
                DependencyProperty.Register("TextoDelCheck" , typeof(string) , typeof(CheckConInfo) ,
                        new FrameworkPropertyMetadata(defaultValue: "Texto del check" ,
                            propertyChangedCallback: new PropertyChangedCallback(OnTextoDelCheckChanged) ,
                            flags: flags));


        public static readonly DependencyProperty PropiedadTag =
                DependencyProperty.Register("TextoDelInfo" , typeof(string) , typeof(CheckConInfo) ,
                        new FrameworkPropertyMetadata(defaultValue: "Mas info" ,
                            propertyChangedCallback: new PropertyChangedCallback(OnTextoDelInfoChanged) ,
                            flags: flagsInfo));


        public string TextoDelCheck
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


        private static void OnTextoDelCheckChanged(DependencyObject d , DependencyPropertyChangedEventArgs e)
        {
            CheckConInfo target = (CheckConInfo)d;
            string oldTexto = (string)e.OldValue;
            string newTexto = target.TextoDelCheck;
            target.OnTextoDelCheckChanged(oldTexto , newTexto);
        }


        protected virtual void OnTextoDelCheckChanged(string oldTexto , string newTexto)
        {
            TextoCheck.Text = newTexto;
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
            CheckConInfo targetInfo = (CheckConInfo)d;
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
