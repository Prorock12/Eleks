   M S B A M L   `   `   `  ����C  ?CommonUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK3clr-namespace:CommonUI.Converters;assembly=CommonUICommonUI.Converters  5      5(clr-namespace:CommonUI;assembly=CommonUICommonUI  5      K GModules.Redactor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Modules.Redactor.PropertiesModules.Redactor.Properties 5      A%clr-namespace:Modules.Redactor.StylesModules.Redactor.Styles 5      I)clr-namespace:Modules.Redactor.ViewModelsModules.Redactor.ViewModels 5	      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089/    )CommonUI.Converters.ColorToBrushConverter   ColorToBrushConverter  �� 
TargetType ' #MaterialDesignToolToggleFlatListBox �� BasedOn �� Property �� Value ! MaterialDesignFlatMidBgButton  ElementControlTemplate �� 
TargetType �� CornerRadius �� Padding �� Color J� Effect-  'System.Windows.Media.Effects.BlurEffect	   Radius
   
KernelType   RenderingBias3  -System.Windows.Media.Effects.DropShadowEffect   
BlurRadius   Color   	Direction   Opacity   ShadowDepth �� Triggers ]� 
Conditions �� Property �� Value P� Property P� Value  WrapElementContainerStyle �� Triggers  CanvasElementContainerStyle 8� X 8� Y �� Angle  AddButtonControlTemplate  RemoveButtonControlTemplate �� DataType6  0Modules.Redactor.ViewModels.TextElementViewModel"   CommonUI.RichTextBoxExtended  Name  MaterialDesignRichTextBox   Text �� Orientation+  %Modules.Redactor.Properties.Resources   Load  �� ElementName!   Save7  1Modules.Redactor.ViewModels.ImageElementViewModel7  1Modules.Redactor.ViewModels.VideoElementViewModel)  #Modules.Redactor.Styles.VideoPlayer "	 ElementsListBoxControlTemplate 
 ElementWrapPanel  ElementCanvasPanel  ElementListBoxStyle" �� Binding# �� Value  AddButtonStyle  RemoveButtonStyle�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    8d2http://schemas.microsoft.com/expression/blend/2008  5      :x,http://schemas.microsoft.com/winfx/2006/xaml     5      Bmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      B
converters3clr-namespace:CommonUI.Converters;assembly=CommonUI  5      3common(clr-namespace:CommonUI;assembly=CommonUI  5      :localization)clr-namespace:Modules.Redactor.Properties  5      /local%clr-namespace:Modules.Redactor.Styles  5      9viewModels1)clr-namespace:Modules.Redactor.ViewModels  5	      %p  &	        '��      7  '�� e     7  '�� �     '�� %    '�� �    &	 �    &	     7  &	 �	    &	 �    &	 �    (�� 5    5�      *, +)(��     5�      *, +)(�� r    5�      *, +)&		 �    &	
 =    &	 e    &	 �    7��7 
 7  7 	 7  7  &	 �    7��7  &	 �    7��7     5      6'   �� 5      "  ��6   8   .�5   
   ��  � ��$ 0 0 0 2q�6,   5      �� 5      "  ��6   8   .�5   
   ��  � ��$ 1q�6#   5      �� 5      "  ��6   .�5   
   ��  � ��$ 10 17 10 10q�6#   �� 5   
    � ��$ 5q�6$   5       �� 5"      "  ��6   .�5#   
   ��  � ��
 �����6(   �� 5$   
    � ��$ 0 0 2 2q�6,   5%      �� 5'      "  ��6   5)      �� 5+      " ��65   .R�5,   
   �� #��z��6   $ 5��5-      #��z��5.      #��z��5/      #��z��50      ._�51      �� ��52      �� *VisualElement.BorderThickness+ 53      �� *VisualElement.CornerRadius+ 54      �� *VisualElement.Padding+��55      �� 56       6&   �� *VisualElement.Background+��58      �� 59       6&   �� *VisualElement.BorderBrush+ 5;        5<      	 6!   �� *VisualElement.Radius+
 5=   !   �� *VisualElement.KernelType+ 5>   !   �� *VisualElement.RenderingBias+._�5@      ��  5A        5B       6+   �� *VisualElement.BlurRadius+ 5C   +   �� *VisualElement.Color+ 5D   +   �� *VisualElement.Direction+ 5E   +   �� *VisualElement.Opacity+ 5F   +   �� *VisualElement.ShadowDepth+5H      5I      5J       5K   
   ]� 5L       5M      �� 5N       �@J�IsMouseOver . 67   /�5P      �� 5Q       � �� �	#1F26A0DA63   �� 5R       � �� �	#A826A0DA64   5T      ]� 5U       5V      �� 5W       �@��IsSelectionActive .  6F   �� 5X       �@��
IsSelected . 66   /�5Z      �� 5[       � �� �	#3DDADADA63   �� 5\       � �� �	#FFDADADA64   5^      ]� 5_       5`      �� 5a       �@��IsSelectionActive . 6F   �� 5b       �@��
IsSelected . 66   /�5d      �� 5e       � �� �	#3D26A0DA63   �� 5f       � �� �	#FF26A0DA64   5h      P� 5i       � {� .  . �5j      ��  � �� �	#FF6D6D6D6C   5k      5m      �� 5o      "  ��6/   .�5p   
   ��  � �� 6"   �� *VisualElement.Width+�� 5q   
    � �� 6#   �� *VisualElement.Height+�� 5r   
    � �� 6#   �� *VisualElement.Margin+�� 5s   
    � ��8   6%    5t   
   P� 5u       �@J�	IsFocused . . �5v      ��  � ��
 �`���6/   �� 5w       � ��
 �  ��60   �� 5x       � ��$ 3q�64   5y      5{      �� 5}      "  ��61   .�5~   
   ��  �@��Left 6(   �� *VisualElement.X+�� 5   
    �@��Top 6'   �� *VisualElement.Y+�� 5�   
    � �� 6"   �� *VisualElement.Width+�� 5�   
    � �� 6#   �� *VisualElement.Height+�� 5�   
    � �� 6#   �� *VisualElement.Margin+�� 5�   
    �@J�RenderTransformOrigin 5�      8� 5�      $ 50Q�6   $ 50Q�6   5�      �� 5�   
    � z� 5�      �� 5�       6"   �� *VisualElement.Angle+5�      5�      �� 5�      " ��67   .R�5�   
   �� #��z��6   $ 5��5�      #��z��5�      #��z��5�      #��z��5�      ._�5�      �� #��z��6   5�       5�   
   P� 5�       �@J�IsMouseOver . . �5�      ��  � ��
 � � �6/   �� 5�       � ��
 � ���6/   5�      P� 5�       � {� .  . �5�      ��  � ��
 �����6/   �� 5�       � ��
 �����6/   5�      5�      �� 5�      " ��6:   .R�5�   
   �� #��z��6   $ 5��5�      #��z��5�      #��z��5�      #��z��5�      ._�5�      �� #��z��6    5�       5�   
   P� 5�       �@J�IsMouseOver . . �5�      ��  � ��
 �  ��6/   �� 5�       � ��
 �   �6/   5�      P� 5�       � {� .  . �5�      ��  � ��
 �����6/   �� 5�       � ��
 �����6/   5�      5�      �� 5�      "  6   .R�5�   
   �� ._�5�      �� .+�5�        $ MyRtb��6-   $
��Auto��5�   -   
���   �$��5q�5�   -   #���  5�   -    5�   <   �� *TextElement.Text+��5�   -   �� *TextElement.Background+5�   -   �� 5�      $ 
Horizontal=�6   .+�5�      �� #��Z 6   ��6N   �� *LoadCommand+$  MyRtb���� 5�      #��Z! 6   ��6N   �� *SaveCommand+$  MyRtb��5�      5�       5�        5�      5�      5�      �� 5�      "  6   .R�5�   
   �� ��6   �� *ImageElement.Path+5�      �� 5�      "  6   .R�5�   
     5�      �� 5�      " ��6=   .R�5�   
   �� #��z��6   $ 5��5�      #��z��5�      #��z��5�      #��z��5�      ._�5�      �� 5�      5�      �� 5�      .R�5�   
   � 5�      �� 5�      .R�5�   
   �� 5�      �� 5�      "  ��5�      8   .�5�   
   ��  � ��8  6'   �� 5�   
    � ��8  6/   �� 5�   
    � ��8  6%    5�   
   �� 5�      " 6   �� *IsStackView+# True6;   .a�5�      ��  � ��8  6/   �� 5�       � ��8  67   5�      5�      �� 5�      "  ��5�      8   .�5�   
   ��  � ��8  6%   5�      �� 5�      "  ��5�      8   .�5  
   ��  � ��8  6%   5     5     