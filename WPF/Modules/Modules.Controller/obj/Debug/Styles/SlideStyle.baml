   M S B A M L   `   `   `  ����A  =Models, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS6clr-namespace:Models.Interfaces.Models;assembly=ModelsModels.Interfaces.Models  5      M IModules.Controller, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Modules.Controller.ViewModelsModules.Controller.ViewModels 5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType �� Property �� Value !  MaterialDesignFlatMidBgButton �� BasedOn  AddButtonControlTemplate �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value  ElementCanvasItemsPanel  ElementDataTemplate	 �� DataType'    !Models.Interfaces.Models.IElement
 �� Padding  ElementsListBoxStyle  SlideListBoxContentTemplate2  ,Modules.Controller.ViewModels.SlideViewModel  SlideListBoxWrapItemsPanel  SlideListBoxStackItemsPanel  SlideListBoxControlTemplate 	 SlidesListBoxStyle �� Triggers �� Binding �� Value 
 AddButtonStyle�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      Amodels6clr-namespace:Models.Interfaces.Models;assembly=Models  5      :
viewModels+clr-namespace:Modules.Controller.ViewModels  5      %�	  '��       '�� �     7   '�� �     '�� y    &	 �    &	 �    &	 �    &	 #    7  7  &	 �    7  &	 3    &	 [    &	 �    &		 �    7��7  7  7  7  &	
 �    7��7  �� 5      "  ��6   .�5   
   ��  � ��$ 20(�6%   �� 5   
    � ��$ 0 0 0 2q�6,   �� 5	   
    � ��
 �����6(   5
      �� 5      "  ��6   8   .�5   
   ��  � ��$ 1q�6#   5      �� 5      "  ��6   .�5   
   ��  � ��
 �����6'   �� 5   
    � ��$ Center=�6.   �� 5   
    � ��$ 10q�6#   5      �� 5      "  ��6   .�5   
   ��  � ��
 �����6(   �� 5   
    � ��$ 2 0 0 2q�6,   5      �� 5      " ��67   .R�5    
   �� #��z��6   $ 5��5!      #��z��5"      #��z��5#      #��z��5$      ._�5%      �� #��z��6   5&       5(   
   P� 5)       �@J�IsMouseOver . . �5*      ��  � ��
 � � �6/   �� 5+       � ��
 � ���6/   5,      P� 5-       � {� .  . �5.      ��  � ��
 �����6/   �� 5/       � ��
 �����6/   50      52      �� 54      .R�55   
   �� 56      �� 58      "	   6/   .R�59   
   �� $
 5q�5:      ��59      �� *Name+5:      5;      �� 5=      "  ��6)   .�5>   
   ��  � ��8   6'   �� 5?   
    � �� 5@      �� 5A      .�5B      ��  �@��Left 64   �� *X+�� 5C       �@��Top 63   �� *Y+�� 5D       � �� 66   �� *Width+�� 5E       � �� 67   �� *Height+�� 5F       � ��8  6G   5G      5I      5J      �� 5L      "	  67   .R�5M   
   (� .��5N      �� $	��200��5O      $	��200��5P      8��  }�. ��5N      �� *Slide.Elements+5R      5S      5T      �� 5V      .R�5W   
   � 5X      �� 5Z      .R�5[   
   �� 5\      �� 5^      " ��6:   .R�5_   
   �� #��z��6   #��z��5`      #��z��5a      ._�5b      �� 5c      5d      �� 5f      "  ��5g      8   .�5i   
   ��  � ��8  6'   �� 5j   
    � ��8  6%   �� 5k   
    � �� 5l      �� 5m      .�5n      ��  � ��8  6G   �� 5o       � ��$	 100��66   �� 5p       � ��$	 100��67   5q      5s       5u   
   �� 5v       6   �� *IsStackView+ True6:   .a�5w      ��  � ��8  6/   5x      5z      �� 5|      "  ��5}      8   .�5   
   ��  � ��8  6%   5�      5�      