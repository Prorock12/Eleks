   M S B A M L   `   `   `  ����I  EInfrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG4clr-namespace:Infrastructure;assembly=InfrastructureInfrastructure  5      J FModules.Effects, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Modules.Effects.PropertiesModules.Effects.Properties 5      G(clr-namespace:Modules.Effects.ViewModelsModules.Effects.ViewModels 5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   TextErrorStyle  �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value �� Self �� RelativeSource �� Path  MaterialDesignComboBox	 �� BasedOn  BorderTemplate
 �� DataType"    Infrastructure.ExtendedColor6  0Modules.Effects.ViewModels.BorderEffectViewModel �� Orientation*  $Modules.Effects.Properties.Resources   
Background �� SelectedItem �� UpdateSourceTrigger(   "Infrastructure.ExtendedColorHelper   Colors �� Source   BorderBrush   BorderThickness" �� ValidatesOnNotifyDataErrors   CornerRadius   Padding4  .Modules.Effects.ViewModels.BlurEffectViewModel   Radius   
KernelType/   )Infrastructure.EnumBindingSourceExtention   
RenderBias8  2Modules.Effects.ViewModels.PositionEffectViewModel   X   Y   Width   Height   Angle4  .Modules.Effects.ViewModels.DropShadowViewModel   Color   Opacity    
BlurRadius!   	Direction"   ShadowDepth6  0Modules.Effects.ViewModels.MarginEffectViewModel#   Left
$   Top%   Right&   Bottom�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      Ginfrastructure4clr-namespace:Infrastructure;assembly=Infrastructure  5      9localization(clr-namespace:Modules.Effects.Properties  5      2local(clr-namespace:Modules.Effects.ViewModels  5      %�  &	        '�� �    '�� 2    7  &	 T    (�� �    5,      *, +)7  7  7   7   7   (�� �    5R      *, +)(�� �	    5i      *, +)(�� L    5�      *, +)7  (�� G    5�      *, +)�� 5      "  ��6#   .�5   
   ��  �@=�ErrorTemplate 5	      �� 5
      TextErrorTemplate��.R�5      ]� ��. .+�5      �� .v�5      �� 
���  ��$��2q�5   %   5      �� 5      $��20(�6$   
���  ����5   $   �� *[0].ErrorContent+5      5      5       5   
   P� 5       �@=�HasError . . �5      ��  �@�ToolTip 5      �� # Z $) #(Validation.Errors)[0].ErrorContent�5      5       �� 5"      "  ��6   .�5#   
   ��  � �� 6#   �� *Name+5$      �� 5&      "  ��6   8	   6+   �� 5(      "
   6*   .R�5)   
   �� ��6   �� *Name+5*      �� 5,      "
  6   .R�5-   
   �� .+�5.      �� $��10q�6   $ 
Horizontal=�6%   .+�5/      �� $��5q�6   #��Z 6'   �� 50      $	��100��6   8��   52      �� *ExtendedBackgroundColor+$ PropertyChanged=���53      �� # Z 54      �� 56      $��10q�6   $ 
Horizontal=�6%   .+�57      �� $��5q�6   #��Z 6'   �� 58      $	��100��6   8��  5:      �� *ExtendedBorderBrushColor+$ PropertyChanged=���5;      �� # Z 5<      �� 5>      $��10q�6   $ 
Horizontal=�6%   .+�5?      �� $��5q�6   #��Z 6'   �� 5@      8�� ��5A      �� *BorderThickness+$ PropertyChanged=� . 5B      �� 5D      $��10q�6   $ 
Horizontal=�6%   .+�5E      �� $��5q�6   #��Z 6'   �� 5F      8�� ��5G      �� *CornerRadius+$ PropertyChanged=� . 5H      �� 5J      $��10q�6   $ 
Horizontal=�6%   .+�5K      �� $��5q�6   #��Z 6'   �� 5L      8�� ��5M      �� *	Padding+$ PropertyChanged=� . 5N      5O      5P      �� 5R      "
  6   .R�5S   
   �� .+�5T      �� $��10q�6   $ 
Horizontal=�6%   .+�5U      �� $��5q�6   #��Z 6'   �� 5V      ��6   �� *BlurEffect.Radius+$ PropertyChanged=�5W      �� 5Y      $��10q�6   $ 
Horizontal=�6%   .+�5Z      �� $��5q�6   #��Z 6'   �� 5[      $	��100��6    5\      �� *BlurEffect.KernelType+$ PropertyChanged=���5]      ��    *M� *
KernelType++5^      �� 5`      $��10q�6   $ 
Horizontal=�6%   .+�5a      �� $��5q�6   #��Z 6'   �� 5b      $	��100��6    5c      �� *BlurEffect.RenderingBias+$ PropertyChanged=���5d      ��    *M� *RenderingBias++5e      5f      5g      �� 5i      "
  6   .R�5j   
   �� .+�5k      �� $��10q�6   $ 
Horizontal=�6%   .+�5l      �� $��5q�6   #��Z 6'   �� 5m      ��6   �� *PositionEffect.X+$ PropertyChanged=�5n      �� 5p      $��10q�6   $ 
Horizontal=�6%   .+�5q      �� $��5q�6   #��Z 6'   �� 5r      ��6   �� *PositionEffect.Y+$ PropertyChanged=�5s      �� 5u      $��10q�6   $ 
Horizontal=�6%   .+�5v      �� $��5q�6   #��Z 6'   �� 5w      ��6   �� *PositionEffect.Width+$ PropertyChanged=�5x      �� 5z      $��10q�6   $ 
Horizontal=�6%   .+�5{      �� $��5q�6   #��Z 6'   �� 5|      ��6   �� *PositionEffect.Height+$ PropertyChanged=�5}      �� 5      $��10q�6   $ 
Horizontal=�6%   .+�5�      �� $��5q�6   #��Z 6'   �� 5�      ��6   �� *PositionEffect.Angle+$ PropertyChanged=�5�      5�      5�      �� 5�      "
  6   .R�5�   
   �� .+�5�      �� $��10q�6   $ 
Horizontal=�6%   .+�5�      �� $��5q�6   #��Z 6'   �� 5�      $	��100��6   8��   5�      �� *ExtendedDropShadowColor+$ PropertyChanged=���5�      �� # Z 5�      �� 5�      $��10q�6   $ 
Horizontal=�6%   .+�5�      �� $��5q�6   #��Z 6'   �� 5�      ��6   �� *DropShadowEffect.Opacity+$ PropertyChanged=�5�      �� 5�      $��10q�6   $ 
Horizontal=�6%   .+�5�      �� $��5q�6   #��Z  6'   �� 5�      ��6   �� *DropShadowEffect.BlurRadius+$ PropertyChanged=�5�      �� 5�      $��10q�6   $ 
Horizontal=�6%   .+�5�      �� $��5q�6   #��Z! 6'   �� 5�      ��6   �� *DropShadowEffect.Direction+$ PropertyChanged=�5�      �� 5�      $��10q�6   $ 
Horizontal=�6%   .+�5�      �� $��5q�6   #��Z" 6'   �� 5�      ��6   �� *DropShadowEffect.ShadowDepth+$ PropertyChanged=�5�      5�      5�      �� 5�      "
  6   .R�5�   
   �� .+�5�      �� $��10q�6   $ 
Horizontal=�6%   .+�5�      �� $��5q�6   #��Z# 6'   �� 5�      ��6   �� *Left+$ PropertyChanged=�5�      �� 5�      $��10q�6   $ 
Horizontal=�6%   .+�5�      �� $��5q�6   #��Z$ 6'   �� 5�      ��6   �� *Top+$ PropertyChanged=�5�      �� 5�      $��10q�6   $ 
Horizontal=�6%   .+�5�      �� $��5q�6   #��Z% 6'   �� 5�      ��6   �� *Right+$ PropertyChanged=�5�      �� 5�      $��10q�6   $ 
Horizontal=�6%   .+�5�      �� $��5q�6   #��Z& 6'   �� 5�      ��6   �� *Bottom+$ PropertyChanged=�5�      5�      5�      5�      