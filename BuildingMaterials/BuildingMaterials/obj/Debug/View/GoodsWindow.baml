   M S B A M L   `   `   `  ����L  HBuildingMaterials, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:BuildingMaterials.ViewBuildingMaterials.View  5   	   K*clr-namespace:BuildingMaterials.ConvertersBuildingMaterials.Converters  6<   (    "BuildingMaterials.View.GoodsWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:BuildingMaterials.View     5   	   =local1*clr-namespace:BuildingMaterials.Converters     6<     � Title$  GoodsWindow��5   	   $	��610��6   $
��1060��6*   $	��610��67   $
��1060��6G   $
��1060��5	   	    � 
ResizeMode$ CanMinimize=�6    � WindowStartupLocation$ CenterScreen=�62    � 	Resources 5      1   +BuildingMaterials.Converters.ImageConverter   ImageConverter��%   &	          5   
   6    5      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      .+�5   
   � $��1��6   .+�5      �� 
�������
���   �$��3q�6A   ._�5      ��  �� SelectedItem 6   �� *SelectedProduct+��5      �� *	Product+��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   $��10q�6B   .+�5   "   �� 
�������
���   �$��1q�6U   ._�5   &   �� $	��200��6w   $	��200��6�   ��6,   �� *ProductPhoto+ �� 	Converter# [  6�   5   #   �� 5   "   
�������
���   �$��1q�6U   ._�5   &   �� $��10q�61   $	��550��6=   .+�5    *   �� $
��Bold"�6Q   $��3q�6c   ��64   �� *ProductName+6c   �� 5!   *   $
��Wrap=�6Q   $��3q�6e   ��64   �� *Description+6e   �� 5"   *   $"��Производитель: ��60   $��3q�6J   �� 5#   *   $��Italic$�6c   $��3q�6v   ��64   �� *Manufacturer.ManufacturerName+6v   �� 5$   *   $��
Цена: ��60   $��3q�6A   �� 5%   *   $
��Bold"�6R   $��3q�6d   ��64   �� *ProductPrice+6d   5&   '   5'   #   �� 5(   "   
�������
���   �$��1q�6U   ._�5)   &   �� $��10q�61   $��Center=�6=   $	��200��6Z   $��Center=�6i   .+�5*   *   �� $(��"Наличие на складе: ��60   $��3q�6N   $��Center=�6Y   $��Center=�6t   �� 5+   *   $��3q�6S   $��Center=�6^   $��Center=�6y   ��64   �� *StorageAmount+6y   5,   '   5-   #   5.      5/      51      52      53      � 54   
   $��0��6    � ColumnDefinitions 55      �� 56      �� 57      �� 58      .+�5:      �� -   5        $��
AddNewItem��5:   4   $��Добавить��6   $��10q�6(   6F   �� 5;      -   5        $��RewriteItem��5;   4   $��Изменить��6   $��10q�6(   $��1��6a   �� 5<      -   5        $��
DeleteItem��5<   3   $��Удалить��6   $��10q�6'   $��2��6^   5=      5>      5?      