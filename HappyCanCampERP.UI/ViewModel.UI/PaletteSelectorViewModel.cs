using System.Collections.Generic;
using System.Windows.Input;
using HappyCanCampERP.Domain.Domain;
using MaterialDesignColors;
using MaterialDesignThemes.Wpf;

namespace HappyCanCampERP.UI.ViewModel.UI
{
    public class PaletteSelectorViewModel
    {
        public IEnumerable<Swatch> Swatches { get; }
        public PaletteSelectorViewModel()
        {
            Swatches = new SwatchesProvider().Swatches;            
        }

        public ICommand ToggleBaseCommand { get; } = new AnotherCommandImplementation(o => ApplyBase((bool)o));

        private static void ApplyBase(bool isDark)
        {
            new PaletteHelper().SetLightDark(isDark);
        }

        

        public ICommand ApplyPrimaryCommand { get; } = new AnotherCommandImplementation(o => ApplyPrimary((Swatch)o));

        private static void ApplyPrimary(Swatch swatch)
        {
            new PaletteHelper().ReplacePrimaryColor(swatch);
        }

        public ICommand ApplyAccentCommand { get; } = new AnotherCommandImplementation(o => ApplyAccent((Swatch)o));

        private static void ApplyAccent(Swatch swatch)
        {
            new PaletteHelper().ReplaceAccentColor(swatch);
        }
    }
}
