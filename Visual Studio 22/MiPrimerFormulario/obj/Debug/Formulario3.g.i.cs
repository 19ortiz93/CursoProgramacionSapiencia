﻿#pragma checksum "..\..\Formulario3.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DA1763228795288D835F9B1CA08565C37DFB5F4828730D3BD7663FB2780CBDDD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MiPrimerFormulario;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MiPrimerFormulario {
    
    
    /// <summary>
    /// Formulario3
    /// </summary>
    public partial class Formulario3 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\Formulario3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbProductos;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Formulario3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCantidad;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Formulario3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrecio;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Formulario3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbDescuento;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Formulario3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCalcular;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Formulario3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTotal;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MiPrimerFormulario;component/formulario3.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Formulario3.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.cmbProductos = ((System.Windows.Controls.ComboBox)(target));
            
            #line 12 "..\..\Formulario3.xaml"
            this.cmbProductos.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbProductos_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtCantidad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtPrecio = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.rbDescuento = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.btnCalcular = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Formulario3.xaml"
            this.btnCalcular.Click += new System.Windows.RoutedEventHandler(this.btnCalcular_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtTotal = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

