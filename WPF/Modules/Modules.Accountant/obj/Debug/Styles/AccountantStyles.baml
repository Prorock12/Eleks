   M S B A M L   `   `   `  ����C  ?CommonUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK3clr-namespace:CommonUI.Converters;assembly=CommonUICommonUI.Converters  5      I EInfrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG4clr-namespace:Infrastructure;assembly=InfrastructureInfrastructure 5      A =Models, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=+clr-namespace:Models.Models;assembly=ModelsModels.Models 5      M IModules.Accountant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Modules.Accountant.PropertiesModules.Accountant.Properties 5	      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089f bXceed.Wpf.DataGrid.v7.0, Version=7.0.21101.19010, Culture=neutral, PublicKeyToken=ba83ff368b7563c6f	 bXceed.Wpf.Controls.v7.0, Version=7.0.21101.19010, Culture=neutral, PublicKeyToken=ba83ff368b7563c6r
 nXceed.Wpf.DataGrid.ThemePack.5.v7.0, Version=7.0.21101.19010, Culture=neutral, PublicKeyToken=ba83ff368b7563c6r nXceed.Wpf.DataGrid.ThemePack.4.v7.0, Version=7.0.21101.19010, Culture=neutral, PublicKeyToken=ba83ff368b7563c6r nXceed.Wpf.DataGrid.ThemePack.3.v7.0, Version=7.0.21101.19010, Culture=neutral, PublicKeyToken=ba83ff368b7563c6r nXceed.Wpf.DataGrid.ThemePack.2.v7.0, Version=7.0.21101.19010, Culture=neutral, PublicKeyToken=ba83ff368b7563c6n jXceed.Wpf.DataGrid.Views3D.v7.0, Version=7.0.21101.19010, Culture=neutral, PublicKeyToken=ba83ff368b7563c6r nXceed.Wpf.DataGrid.ThemePack.1.v7.0, Version=7.0.21101.19010, Culture=neutral, PublicKeyToken=ba83ff368b7563c65    /CommonUI.Converters.ValueOfWidthHeightConverter   ValueOfWidthHeightConverter(  "Xceed.Wpf.DataGrid.DataGridControl  �� 
TargetType �� Property �� Value-  'System.Windows.Input.KeyboardNavigation-  'Modules.Accountant.Properties.Resources   AddRow m� Command   	DeleteRow " DatamartDataGridTableViewStyle(  "Xceed.Wpf.DataGrid.Views.TableView)  #Xceed.Wpf.DataGrid.Views.UIViewBase  XDataTemplate �� DataType!  Models.Models.VisualElement' 	 !Xceed.Wpf.Controls.NumericTextBox* 	 $Xceed.Wpf.Controls.ValueRangeTextBox   Value:	  4Xceed.Wpf.DataGrid.Markup.CellEditorBindingExtension  YDataTemplate  WidthDataTemplate  HeightDataTemplate  AngleDataTemplate  BorderTemplate"
  Infrastructure.ExtendedColor  ColorsComboBoxDataTemplate �� SelectedValuePath	 � DataContext
 �� RelativeSource �� AncestorType!  Xceed.Wpf.DataGrid.DataCell(  "Infrastructure.ExtendedColorHelper   Colors �� Source �� SelectedValue�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    8d2http://schemas.microsoft.com/expression/blend/2008  5      :x,http://schemas.microsoft.com/winfx/2006/xaml     5      Bmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      Cxcdg*http://schemas.xceed.com/wpf/xaml/datagrid  	 
      5      B
converters3clr-namespace:CommonUI.Converters;assembly=CommonUI  5      Ginfrastructure4clr-namespace:Infrastructure;assembly=Infrastructure  5      6models+clr-namespace:Models.Models;assembly=Models  5      <localization+clr-namespace:Modules.Accountant.Properties  5	      %�  &	        '       &	 i    &	 i    &	 �    &	 �    &	     &	 K    &	 �    &	 �    7     5      6-   �� 5      "   6   .�5   
   ��  �@ AutoCreateColumns .  6.   �� 5   
    �@ TabNavigation$ Local=�6=   �� 5   
    �@�ContextMenu 5      �� 5      .@�5      m� #��Z 6    6Q   �� *AddRowCommand+m� 5      #��Z 6    6T   �� *RemoveRowCommand+5      5      5      �� 5      "   5      .�5   
   ��  �@ ShowFixedColumnSplitter .  5      �� 5!   
    �@ ShowRowSelectorPane .  5"      �� 5#   
   $ �@ IsAlternatingRowStyleEnabled . 5$      �� 5%   
    �@ ColumnStretchMode$
 Last=�5&      �� 5'   
    �@��	AllowDrop .  5(      �� 5)   
    �@ AllowColumnChooser .  5*      �� 5+   
    �@ RemovingGroupCursor 5,      Z� �� 5-   
    �@ TabNavigation$ Continue=�5.      5/      �� 51      "  6)   .R�52   
      6   	  53      �� 55      .R�56   
      6   	  57      �� 59      .R�5:   
      6   	  5;      �� 5=      .R�5>   
      6   	  5?      �� 5A      .R�5B   
      6   	  5C      �� 5E      " 
 6*   .R�5F   
   �� ��6   �� *Name+5G      �� 5I      .R�5J   
   �� 8��  $ Color��5M      	 5J      �� *DataContext+
 �� *FindAncestor+"  ��5L      �� # Z  5N      	  5O      5P      