   M S B A M L   `   `   `  ����I  EInfrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG4clr-namespace:Infrastructure;assembly=InfrastructureInfrastructure  5      I EMyFirstProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:MyFirstProject.ViewModelsMyFirstProject.ViewModels 5      E'clr-namespace:MyFirstProject.PropertiesMyFirstProject.Properties 5	      $   MyFirstProject.Views.ShellView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      Y UPrism.Unity.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59S OPrism.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5      <d2http://schemas.microsoft.com/expression/blend/2008   5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      Fshare4clr-namespace:Infrastructure;assembly=Infrastructure     5      >
viewModels'clr-namespace:MyFirstProject.ViewModels     5      @localization'clr-namespace:MyFirstProject.Properties     5	      T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5
      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel$
  TrueX�5      ��5      �� 5   
    �� 
TargetType" �6      MaterialDesignWindow �� BasedOn# [  6$   .�5      ��  �� Property �@�Title �� Value$ 
MainWindow��6&   �� 5       �@�WindowState$ 	Maximized=�6,   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      ��     Infrastructure.RegionNames   PresentationRegion!  Prism.Regions.RegionManager   
RegionName# Z 6   5      � 5    
   $��1��6    � ColumnDefinitions 5"      �� 5#      $
��Auto �6#   �� 5$      $
��Auto �6#   �� 5%      $��* �6#   �� 5&      $
��0.3* �6#   .+�5)      �� $��0��6   	   SlideRegion# Z	 6-   �� 5+      $��1��6     VerticalGridSplitter#��[ 5,      � 5.      $��2��6    5/      �� 50      $��* �6$   �� 51      $
��Auto �6$   �� 52      $��* �6$   .+�55      �� $��0��6!   
   RedactorRegion# Z
 6.   �� 57      $��1��6     HorizontalGridSplitter#��[ 58      �� 59      $��2��6   .@�5:      �� )  #MyFirstProject.Properties.Resources   
Controller#��Z 6   .��5;      ��    ControllerRegion# Z 6)   5<      �� 5=         Effects#��Z 6   .��5>      ��    EffectRegion# Z 6)   5?      �� 5@         
Accountant#��Z 6   .��5A      ��    
Accountant# Z 6)   5B      �� 5C      $��Change Language��6   .��5D      ��    ChangeLanguage#��Z 6   ��6X   �� *SetLanguageCommand+5E      5F      5G      �� 5I      $��3��6      Library# Z 6-   5K      5L      5M      