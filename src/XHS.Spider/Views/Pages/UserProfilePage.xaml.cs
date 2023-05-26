﻿using System.Windows;
using System.Windows.Controls;
using Wpf.Ui.Common.Interfaces;

namespace XHS.Spider.Views.Pages
{
    /// <summary>
    /// UserProfilePage.xaml 的交互逻辑
    /// </summary>
    public partial class UserProfilePage : INavigableView<ViewModels.UserProfileViewModel>
    {
        public ViewModels.UserProfileViewModel ViewModel
        {
            get;
        }

        public UserProfilePage(ViewModels.UserProfileViewModel viewModel)
        {
            viewModel.InitNullImage();
            ViewModel = viewModel;
            InitializeComponent();
        }
        private void CheckAll_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < this.dgrdView.Items.Count; i++)
            {
                var cntr = dgrdView.ItemContainerGenerator.ContainerFromIndex(i);
                DataGridRow ObjROw = (DataGridRow)cntr;
                if (ObjROw != null)
                {
                    FrameworkElement objElement = dgrdView.Columns[0].GetCellContent(ObjROw);
                    if (objElement != null)
                    {
                        System.Windows.Controls.CheckBox objChk = (System.Windows.Controls.CheckBox)objElement;
                        if (objChk.IsChecked == false)
                        {
                            objChk.IsChecked = true;
                        }
                        else
                        {
                            objChk.IsChecked = false;
                        }
                    }
                }
            }
        }

        private void UiPage_Loaded(object sender, RoutedEventArgs e)
        {
            //scriptHost = ScriptHost.GetScriptHost(webView);
        }
    }
}
