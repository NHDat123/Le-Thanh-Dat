﻿#pragma checksum "D:\Dev C_C++\VS_2022\OrderCoffeeApp\OrderCoffeeApp\Views\MenuPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B6E3923091786CDF4DB1286F3CABF897E3F2ADB3ABBACCFCE86C0C4B99DDCFF7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderCoffeeApp.Views
{
    partial class MenuPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2506")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Microsoft.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2506")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private partial class MenuPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IMenuPage_Bindings
        {
            private global::OrderCoffeeApp.Views.MenuPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.ListView obj6;
            private global::Microsoft.UI.Xaml.Controls.ListView obj11;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj6ItemsSourceDisabled = false;
            private static bool isobj11ItemsSourceDisabled = false;

            private MenuPage_obj1_BindingsTracking bindingsTracking;

            public MenuPage_obj1_Bindings()
            {
                this.bindingsTracking = new MenuPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 47 && columnNumber == 27)
                {
                    isobj6ItemsSourceDisabled = true;
                }
                else if (lineNumber == 21 && columnNumber == 27)
                {
                    isobj11ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 6: // Views\MenuPage.xaml line 47
                        this.obj6 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ListView>(target);
                        break;
                    case 11: // Views\MenuPage.xaml line 21
                        this.obj11 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ListView>(target);
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2506")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
                        }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IMenuPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = global::WinRT.CastExtensions.As<global::OrderCoffeeApp.Views.MenuPage>(newDataRoot);
                    return true;
                }
                return false;
            }

            public void Activated(object obj, global::Microsoft.UI.Xaml.WindowActivatedEventArgs data)
            {
                this.Initialize();
            }

            public void Loading(global::Microsoft.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::OrderCoffeeApp.Views.MenuPage obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Snacks(obj.Snacks, phase);
                        this.Update_Drinks(obj.Drinks, phase);
                    }
                }
            }
            private void Update_Snacks(global::System.Collections.ObjectModel.ObservableCollection<global::OrderCoffeeApp.Models.DrinkItem> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_Snacks(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\MenuPage.xaml line 47
                    if (!isobj6ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj6, obj, null);
                    }
                }
            }
            private void Update_Drinks(global::System.Collections.ObjectModel.ObservableCollection<global::OrderCoffeeApp.Models.DrinkItem> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_Drinks(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\MenuPage.xaml line 21
                    if (!isobj11ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj11, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2506")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class MenuPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<MenuPage_obj1_Bindings> weakRefToBindingObj; 

                public MenuPage_obj1_BindingsTracking(MenuPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<MenuPage_obj1_Bindings>(obj);
                }

                public MenuPage_obj1_Bindings TryGetBindingObject()
                {
                    MenuPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                    UpdateChildListeners_Snacks(null);
                    UpdateChildListeners_Drinks(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MenuPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::OrderCoffeeApp.Views.MenuPage obj = sender as global::OrderCoffeeApp.Views.MenuPage;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_Snacks(obj.Snacks, DATA_CHANGED);
                                bindings.Update_Drinks(obj.Drinks, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Snacks":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Snacks(obj.Snacks, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Drinks":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Drinks(obj.Drinks, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::OrderCoffeeApp.Views.MenuPage obj)
                {
                    MenuPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
                        }
                    }
                }
                public void PropertyChanged_Snacks(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MenuPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::OrderCoffeeApp.Models.DrinkItem> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::OrderCoffeeApp.Models.DrinkItem>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_Snacks(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    MenuPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::OrderCoffeeApp.Models.DrinkItem> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::OrderCoffeeApp.Models.DrinkItem>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::OrderCoffeeApp.Models.DrinkItem> cache_Snacks = null;
                public void UpdateChildListeners_Snacks(global::System.Collections.ObjectModel.ObservableCollection<global::OrderCoffeeApp.Models.DrinkItem> obj)
                {
                    if (obj != cache_Snacks)
                    {
                        if (cache_Snacks != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_Snacks).PropertyChanged -= PropertyChanged_Snacks;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_Snacks).CollectionChanged -= CollectionChanged_Snacks;
                            cache_Snacks = null;
                        }
                        if (obj != null)
                        {
                            cache_Snacks = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_Snacks;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_Snacks;
                        }
                    }
                }
                public void PropertyChanged_Drinks(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MenuPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::OrderCoffeeApp.Models.DrinkItem> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::OrderCoffeeApp.Models.DrinkItem>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_Drinks(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    MenuPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::OrderCoffeeApp.Models.DrinkItem> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::OrderCoffeeApp.Models.DrinkItem>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::OrderCoffeeApp.Models.DrinkItem> cache_Drinks = null;
                public void UpdateChildListeners_Drinks(global::System.Collections.ObjectModel.ObservableCollection<global::OrderCoffeeApp.Models.DrinkItem> obj)
                {
                    if (obj != cache_Drinks)
                    {
                        if (cache_Drinks != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_Drinks).PropertyChanged -= PropertyChanged_Drinks;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_Drinks).CollectionChanged -= CollectionChanged_Drinks;
                            cache_Drinks = null;
                        }
                        if (obj != null)
                        {
                            cache_Drinks = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_Drinks;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_Drinks;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2506")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\MenuPage.xaml line 101
                {
                    this.ConfirmOrder = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.ConfirmOrder).Click += this.ConfirmOrder_Click;
                }
                break;
            case 5: // Views\MenuPage.xaml line 92
                {
                    global::Microsoft.UI.Xaml.Controls.Button element5 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element5).Click += this.CancelOrder_Click;
                }
                break;
            case 9: // Views\MenuPage.xaml line 62
                {
                    global::Microsoft.UI.Xaml.Controls.Button element9 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element9).Click += this.AddToCart_Click;
                }
                break;
            case 10: // Views\MenuPage.xaml line 60
                {
                    global::Microsoft.UI.Xaml.Controls.NumberBox element10 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NumberBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.NumberBox)element10).ValueChanged += this.NumberBox_ValueChanged;
                }
                break;
            case 14: // Views\MenuPage.xaml line 36
                {
                    global::Microsoft.UI.Xaml.Controls.Button element14 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element14).Click += this.AddToCart_Click;
                }
                break;
            case 15: // Views\MenuPage.xaml line 34
                {
                    global::Microsoft.UI.Xaml.Controls.NumberBox element15 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NumberBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.NumberBox)element15).ValueChanged += this.NumberBox_ValueChanged;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }


        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2506")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\MenuPage.xaml line 2
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    MenuPage_obj1_Bindings bindings = new MenuPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

