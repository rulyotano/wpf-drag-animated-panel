using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DraggAnimatedPanelExample
{
	/// <summary>
	/// Interaction logic for DeletePinButtons.xaml
	/// </summary>
	public partial class DeletePinButtons : UserControl
	{
		public DeletePinButtons()
		{
			this.InitializeComponent();
		}
		
		public static readonly DependencyProperty CloseCommandProperty =
          DependencyProperty.Register(
                  "CloseCommandCommand",
                  typeof(ICommand),
                  typeof(DeletePinButtons),
                  new FrameworkPropertyMetadata(null));
		
		public static readonly DependencyProperty IsPinnedProperty =
          DependencyProperty.Register(
                  "IsPinned",
                  typeof(bool),
                  typeof(DeletePinButtons),
                  new FrameworkPropertyMetadata(false));
		
		public ICommand CloseCommand
		{
			get {return (ICommand)GetValue(CloseCommandProperty);}
			set {SetValue(CloseCommandProperty,value);}
		}
		public bool IsPinned
		{
			get {return (bool)GetValue(IsPinnedProperty);}
			set {SetValue(IsPinnedProperty,value);}
		}
	}
}