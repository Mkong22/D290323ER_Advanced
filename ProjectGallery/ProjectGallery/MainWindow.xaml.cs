﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Common;
using ProjectGallery.Controls;

namespace ProjectGallery;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {
	private IProjectMeta[] projects = new IProjectMeta[] {
		new Tic_Tac_Toe.Project(),
		new PersonManager.Project()
	};

	public MainWindow() {
		InitializeComponent();
		InitializeProjectButtons();
	}

	private void InitializeProjectButtons() {
		//int i = 0;

		foreach (var project in projects) {
			//Button button = new Button() {
			//	Width = 100,
			//	Height = 100,
			//	Margin = new Thickness(10)
			//};

			//StackPanel pnl = new StackPanel();

			//pnl.Orientation = Orientation.Vertical;

			//Image img = new Image();
			//img.Width = 50;
			//img.Height = 50;

			//TextBlock tb = new TextBlock();
			//tb.Text = "Button";
			//tb.VerticalAlignment = VerticalAlignment.Center;

			//pnl.Children.Add(img);
			//pnl.Children.Add(tb);
			
			//button.Content = pnl;

			ProjectButton button = new ProjectButton(project) {
				Margin = new Thickness(10),
				Width = 100,
				Height = 130
			};
			ProjectsWrapPanel.Children.Add(button);
		}
	}
}