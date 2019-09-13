﻿using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AEDAT_File_Reader
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        public MainPage()
        {
            
            this.InitializeComponent();
        }

        private void nav_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                //ContentFrame.Navigate(typeof(SettingsPage));
            }
            else
            {
                // Getting the Tag from Content (args.InvokedItem is the content of NavigationViewItem)
                
                if((string)args.InvokedItem == "Summary")
                {
                    ContentFrame.Navigate(typeof(SummaryView));
                }
                else if((string)args.InvokedItem == "Events")
                {
                    ContentFrame.Navigate(typeof(eventList));
                }
                else if ((string)args.InvokedItem == "Event Summaries")
                {
                    ContentFrame.Navigate(typeof(EventSummary));
                }
				else if ((string)args.InvokedItem == "Video")
				{
					ContentFrame.Navigate(typeof(videoPage));
				}
				else if ((string)args.InvokedItem == "Testing")
				{
					ContentFrame.Navigate(typeof(TestPage));
				}
				else if ((string)args.InvokedItem == "Event Chunks")
				{
					ContentFrame.Navigate(typeof(EventChunks));
				}
                else if ((string)args.InvokedItem == "Generate Frames")
                {
                    ContentFrame.Navigate(typeof(GenerateFrames));
                }

            }
        }


        
    }
}
