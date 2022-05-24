using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectTsybirevV3
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            profileImage.Source = ImageSource.FromFile("lgoo.jpg");
            aboutList.ItemsSource = GetMenuList1();
            var homePage = typeof(Views.AboutPage);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;

        }
        public List<MasterMenuItems> GetMenuList1()
        {
            var list = new List<MasterMenuItems>();
            list.Add(new MasterMenuItems()
            {
                Text = "Minust",
                Detail = "Lühike info",
                ImagePath = "about.png",
                TargetPage = typeof(Views.AboutPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Minu kogemus",
                Detail = "Natuke rohkem ...",
                ImagePath = "info.png",
                TargetPage = typeof(Views.ExperiencePage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Minu oskused",
                Detail = "Natuke rohkem ...",
                ImagePath = "smile.png",
                TargetPage = typeof(Views.SkillsPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Minu võidud",
                Detail = "Ma olen uhke!!!",
                ImagePath = "mmm.jpg",
                TargetPage = typeof(Views.AchivemnetsPage)
            });
            return list;
            
        }
        private void aboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (MasterMenuItems)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;
        }
    }
}