   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   E AWpfWorkApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:RecipesBookRecipesBook 5   	   5   /RecipesBook.Models.Application.Windows.EditInfo   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   +localclr-namespace:RecipesBook     5   	   -   5          � Title$  EditInfo��5	   	   $	��734��6   $	��800��6'    � WindowStartupLocation$ CenterScreen=�6i   (   "MahApps.Metro.Controls.MetroWindow   RightWindowCommands 5      +   %MahApps.Metro.Controls.WindowCommands  5   
   .@�5      �� $��Dark theme: ��6   $��12(�6+   )   #MahApps.Metro.Controls.ToggleSwitch  5      -   5          Name$ TBtnDarkTheme��5      
����������	#FFAC1F00$��12(�6`   $��50��6n   $��30��6y   6�   5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $	��85* �6   �� 5      $	��86* �6   �� 5      $
��232* �6   �� 5      $
��232* �6   �� 5      $	��68* �6   .+�5    
   �� $��0��6<   $��2��6I   $��0��6Z   $��2��6j   ��6   ��  �� Path$ NewRecipe.ImagePath�6j   �� 5"   
   $��Изображение��6   $	��Top=�6&   $��0��6>   $��2��6K   $��Center=�6[   $��20(�6x   $	��138��6�   $��37��6�   $
��63,0q�6�   �� 5#   
   -   5         ��Name$ TBImagePath��5#      $��Bottom=�6'   $��0��6C   $��2��6P   $��15(�6�   $��30��6�   ��6a   �� *NewRecipe.ImagePath+6�   �� 5%   
   $��Название��6   $��1��6#   $��2��60   $��Center=�6@   $��20(�6]   $��98��6k   $
��83,0q�6v   �� 5&   
   -   5        $ TBName��5&      $��Bottom=�6"   $��2��6=   $��1��6M   $��15(�6z   $��30��6�   ��6Z   �� *NewRecipe.Name+6�   �� 5(   
   $��Ингредиенты��6   $��2��6&   $��50��63   $	��Top=�6?   $��1��6W   $��Center=�6g   $��20(�6�   $	��132��6�   $
��66,0q�6�   �� 5)   
   -   5        $ TBIngredients��5)      $ �� HorizontalScrollBarVisibility$
 Auto=�6)   "	 �� VerticalScrollBarVisibility$
	 Auto=�6N   $��3��5*      $	��195��6&   $��2��63   $��Bottom=�6@   $��15(�6�   ��6[   �� *NewRecipe.Ingredients+6�   �� 5,   
   $��Инструкция��6   $��3��6%   $��1��62   $	��Top=�6B   $��Center=�6Z   $��20(�6w   $	��120��6�   $��37��6�   $
��72,0q�6�   �� 5-   
   -   5        $ TBCookingInstruction��5-      $
 Auto=�60   $
	 Auto=�6U   $��3��5.      $	��195��6&   $��Bottom=�63   $��3��6N   $��15(�6�   ��6[   �� *NewRecipe.CookingInstruction+6�   �� 50   
   -   5        
 ��Name$
 BtnAdd��50      $	��200��6!   $��0��6-   $��4��6=   $��Center=�6J   $��Добавить��6g   $y�Hidden=�6z   $
��32,0q�6�   ��6�   �� *
AddCommand+��6�   �� *	NewRecipe+6�   �� 51   
   -   5        $
 BtnSave��51      $	��200��6"   $��0��6.   $��4��6>   $��Center=�6K   $��Сохранить��6h   $
��32,0q�6�   ��6�   �� *EditCommand+��6�   �� *
EditRecipe+6�   �� 52   
   -	   5        $
 	BtnCancel��52      $	��200��6$   $��2��60   $��4��6@   $��Center=�6M   $��Отмена��6j   $
��32,0q�6�   53      54      