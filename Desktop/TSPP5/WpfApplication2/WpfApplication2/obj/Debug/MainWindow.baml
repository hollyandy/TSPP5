   M S B A M L   `   `   `  ����J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  5   	        WpfApplication2.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication2     5   	     � Title$   Вхід у систему��5   	   $	��416��6    $	��668��6-    � Icon$ 
Accept.ico��69    � 
ResizeMode$ NoResize=�6K    � WindowStyle$ ThreeDBorderWindow=�6a   $��1q�6�   ���	#FF020202.��5	      � -   5         J� RenderTransformOrigin$	 0,0&�5	      $��-200,-76,-334,-166q�6'   z�5
   
   V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0.266Q�6"   T� 5      5      ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5      � 	 � Color$	 White��6   
 � Offset$
 0.978Q�6-   � 5      $	 	#FFB2B2B2��6   $
 0.051Q�61   � 5      $	 	#FFE2E4BD��6   $
 0.496Q�61   5      .+�5   
   G� -   5         G�Name$ passwordBox��5      $
��Left=�6+   $��352,313,0,0q�6F   $	��Top=�6[   $	��169��6s   $��29��6   $��Segoe UI Black)�6�    J� IsManipulationEnabled .  G� SelectionBrush �	#FF202021$��17.333(�6�   �� 5   
   -   5         ��Name$ label2��5      $��Користувач:��6    $
��Left=�66   $��224,161,0,0q�6Q   $	��Top=�6f   $	��108��6~   $��Segoe UI Semibold)�6�   $��17.333(�6�   $
��Bold"�6�   $��32��6�   �� 5   
   -   5         ��Name$ button��5      $��Вхід��6!   $
��Left=�60   $��583,351,0,0q�6K   $	��Top=�6`   $��73��6x   $��Segoe UI Semibold)�6�   $��18.667(�6�   $��28��6�   �� 5   
   -   5         ��Name$ textBox��5      $
��Left=�6#   $��30��6>   $��352,252.297,0,0q�6J    �� TextWrapping$
 Wrap=�6c   $��* * * * * * * *��6w   $	��Top=�6�   $	��128��6�    �� 	MaxLength$ 4��6�   $
��Bold"�6�   $��17.333(�6�    .  �� AutoWordSelection .  �� CharacterCasing$ Upper=�6  &   System.Windows.Media.TextOptions   TextHintingMode$ Animated=�62   �� TextAlignment$ Center=�6Y   � UseLayoutRounding .  6�  	� 5   
   -   5         	�Name$ radioButton��5      $��Студент��6+   $
��Left=�6=   $��337,169,0,0q�6X   $	��Top=�6m    	� 	GroupName$ User_select��6�   $��17.333(�6�    d� 	IsChecked$
 TrueY�6�   $	 0,0&�6�   $��Italic$�6�   $��21��6  $��95��6  	� 5   
   -   5        $ radioButton1��5      $ ��Адміністратор��6,   $
��Left=�6D   $��337,209,0,0q�6_   $	��Top=�6t   $ User_select��6�   $��17.333(�6�   $��Italic$�6�   $��21��6�   $	��143��6�   	� 5   
   -   5        $ radioButton2��5      $+��%Модератор (Викладач)��6,   $
��Left=�6K   $��337,188,0,0q�6f   $	��Top=�6{   $ User_select��6�   $��17.333(�6�   $��Italic$�6�   $��22��6�   $	��201��6�   �� 5    
   -	   5        $ label2_Copy��5       $��Логін:��6%   $
��Left=�66   $��275,248,0,0q�6Q   $	��Top=�6f   $��57��6~   $��Segoe UI Semibold)�6�   $��17.333(�6�   $
��Bold"�6�   $��32��6�   �� 5!   
   -
   5        $ label2_Copy1��5!      $��Пароль:��6&   $
��Left=�68   $��262,307,0,0q�6S   $	��Top=�6h   $��93��6�   $��Segoe UI Semibold)�6�   $��17.333(�6�   $
��Bold"�6�   $��32��6�   �� 5"   
   -   5        $ label��5"      $F��@  Система екзаменаційного контролю��6   $��305,104,492,0q�6L   $	��Top=�6c   $	��397��6{   $$��Tw Cen MT Condensed Extra Bold)�6�   $��SemiBold"�6�   $��31��6�   $��20(�6�   $��Center=�6�   $��Italic$�6   
�������6  �� 5#   
   -   5        $ label1��5#      $�� ��6    $
��Left=�6+   $��
80,342,0,0q�6F   $	��Top=�6Z   $	��485��6r   
���  ��$��18.667(�6�   $��MV Boli)�6�   $
��Bold"�6�   $��39��6�   �� 5$   
   -   5        $ textBox1��5$      $
��Left=�6$   $��29��6?   $��240,243,0,0q�6K   $
 Wrap=�6`   $��TextBox��6t   $	��Top=�6�   $	��172��6�   $y�Hidden=�6�   $��17.333(�6�   �� 5%   
   -   5         ��Name$ image1��5%      $
��Left=�6    $��45��6;   $��563,148,0,0q�6G   $	��Top=�6\   $��45��6t   $��symbols-warning.png��6    J� Opacity$	 0.8Q�6�   $y�Hidden=�6�   5&      5'      