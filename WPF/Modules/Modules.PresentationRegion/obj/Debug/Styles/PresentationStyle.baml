   M S B A M L   `   `   `  ����U  QModules.PresentationRegion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:Modules.PresentationRegion.ViewModels%Modules.PresentationRegion.ViewModels  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType   MaterialDesignListBox �� BasedOn �� Property �� Value ! MaterialDesignFlatMidBgButton  BaseStackPanelStyle  AddButtonControlTemplate �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value  RemoveButtonControlTemplate  PresentationControlTemplate  PresentationTemplate	 �� DataTypeA    ;Modules.PresentationRegion.ViewModels.PresentationViewModel  PresentationPanel  PresentationsListBoxStyle 	 AddButtonStyle 
 RemoveButtonStyle
 �� Triggers�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    8d2http://schemas.microsoft.com/expression/blend/2008  5      :x,http://schemas.microsoft.com/winfx/2006/xaml     5      Bmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      B
viewModels3clr-namespace:Modules.PresentationRegion.ViewModels  5      %�  '��       7   '�� v     7  '�� �     '�� /    7  &	 U    &	 �    &	 �    &	 3    &	 �    &	 �    7��7  7  7  &		 �    7��7  &	
 �    7��7  '�� 4    �� 5      "  ��6   8   .�5	   
   ��  � ��$ 20(�6%   �� 5
   
    � ��$ 0 0 2 0q�6,   5      �� 5      "  ��6   8   .�5   
   ��  � ��$ 1q�6#   5      �� 5      "  ��6   .�5   
   ��  � ��
 �����6(   �� 5   
    � ��$ 2q�6,   5      �� 5      "  ��6   8   5      �� 5      " ��67   .R�5   
   �� #��z��6   $ 5��5       #��z��5!      #��z��5"      #��z��5#      ._�5$      �� #��z��6   5%       5'   
   P� 5(       �@J�IsMouseOver . . �5)      ��  � ��
 � � �6/   �� 5*       � ��
 � ���6/   5+      5-      �� 5/      " ��6:   .R�51   
   �� #��z��6   $ 5��52      #��z��53      #��z��54      #��z��55      ._�56      �� #��z��6   57       59   
   P� 5:       �@J�IsMouseOver . . �5;      ��  � ��
 �  ��6/   �� 5<       � ��
 � ���6/   5=      5?      �� 5A      " ��6:   .R�5B   
   �� #��z��6   #��z��5C      #��z��5D      ._�5E      �� 5F      5G      �� 5I      "	   60   .R�5J   
   �� $��5q�5K      $
��Auto��5L      ��5J      �� *Presentation.Name+5L      5M      �� 5O      .R�5P   
   � 5Q      �� 5S      "  ��5T      8   .�5V   
   ��  � ��8  6'   �� 5W   
    � ��8  6)   �� 5X   
    � ��8  6%   �� 5Y   
    � ��$ Disabled=�6G   5Z      �� 5\      "  ��5]      8   .�5_   
   ��  � ��8  6%   5`      �� 5b      "  ��5c      8   .�5e   
   ��  � ��8  6%   5f      �� 5h      "  ��6   .�5i   
   ��  � ��$ 5q�6#   
 5k   
   P� 5l       �@J�	IsFocused . . �5m      ��  � ��
 �`���6/   5n      5p      5q      