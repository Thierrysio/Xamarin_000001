﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_000001.VueModeles;

namespace Xamarin_000001.Vues
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VisiteVue : ContentPage
    {
        VisiteVueModele vueModele;
        public VisiteVue()
        {

            InitializeComponent();
            BindingContext = vueModele = new VisiteVueModele();
        }
    }
}