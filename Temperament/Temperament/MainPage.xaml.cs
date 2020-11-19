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
                            Source = "Choleric4.jpg",
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
                             Source = "Sanguine1.jpg",
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
                             Source = "Phlegmatic3.jpg",
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
                           Source = "Meloncholic2.jpg",
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        }
                    }
                }
            };

        }
    }
}

