using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Temperament
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            var CholericContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Chioleric",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "Choleric.jpg",
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        }
                    }
                }
            };
            var CholericOPContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "ChiolericOP",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "CholericOP.jpg",
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        }
                    }
                }
            };
            var SanguineContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Sanguine",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "Sanguine.jpg",
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        }
                    }
                }
            };
            var SanguineOPContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "SanguineOP",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "SanguineOP.jpg",
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        }
                    }
                }
            };
            var PhlegmaticContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Phlegmatic",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "Phlegmatic.jpg",
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        }
                    }
                }
            };
            var PhlegmaticOPContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "PhlegmaticOP",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "PhlegmaticOP.jpg",
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        }
                    }
                }
            };
            var MeloncholicContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                          Text = "Meloncholic",
                          FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                          HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "Meloncholic.jpg",
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        }
                    }
                }
            };
            var MeloncholicOPContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                          Text = "MeloncholicOP",
                          FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                          HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "MeloncholicOP.jpg",
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        }
                    }
                }
            };
            Children.Add(CholericContentPage);
            Children.Add(SanguineContentPage);
            Children.Add(PhlegmaticContentPage);
            Children.Add(MeloncholicContentPage);
            Children.Add(CholericOPContentPage);
            Children.Add(SanguineOPContentPage);
            Children.Add(PhlegmaticOPContentPage);
            Children.Add(MeloncholicOPContentPage);
        }
    }
}

