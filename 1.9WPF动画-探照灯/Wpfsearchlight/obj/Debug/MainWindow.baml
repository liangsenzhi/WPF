   M S B A M L   `   `   `  ����  Wpfsearchlight    Wpfsearchlight.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      -   5          �Name$  Window��5       � Title$ 
MainWindow��5      $	��640��5      $	��180��6    � WindowStartupLocation$ CenterScreen=�6    � WindowStyle$
 None=�6@   
���   � � 	Resources 5         Storyboard1 g� AutoReverse g� RepeatBehavior �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame	 O� KeyTime
 O� Value��%G  &	        �� 5	       . $ Forever��66   .��5
      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6#   $
 path��6�   .\�5        $	 0��6   $
 0Q�6'     5      $	 0:0:6��6   $	
 528Q�6+     5      $	 0:0:7��6   $	
 528Q�6+   5      5      5       � Triggers 5      :� 5       :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5      �� #��[  6   5      .��5      � -   5         �Name$ 
LayoutRoot��5      .+�5      �� $��	0,43,0,40q�6   $
��Wrap=�6!   $��    WPF探照灯动画��65   $��64(�6I   $
��Bold"�6W   ���	#FF050F9D��5      �� 5       �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6+   .��5      �  � Color$ 	#FFFF0023��6    � Offset$ 0.109Q�6&   � 5      $ 	#FF04FF59��6   $ 0.948Q�6&   � 5      $ 	#FFFFFA79��6   $ 0.478Q�6&   5      5       �� 5!      -   5         ��Name$
 exit��5!      $
��EXIT��6   $��Right=�6(   $��24��6D   $��0,0,32,55.21q�6P   $��Bottom=�6f   $��45��6�   $��13.333(�6�    � Cursor$
 Hand��6�   F� 5"      -   5         F�Name$
 path��5"   	   ����� A-&�pr �$u�$�pr  ލ#�� ލ#��� ލ#џ�$u�$�6� A-&�6���'�6� ��(џ� ��(��� ��(���'�pr  A-&�pr �        � @KL    � @KL ���     ��	���	#CA000000$��-596,36,-52,36q�6   �� Stretch$
 Fill=�6'   J� RenderTransformOrigin$ 0.5,0.5&�66  z�5#      V� 5$      .~�5%      �� �� 5&      �� 5'      T� 5(      5)      5+      5,      5-      