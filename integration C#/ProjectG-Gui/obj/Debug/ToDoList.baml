   M S B A M L   `   `   `  ����  ProjectG-Gui    ProjectG_Gui.ToDoList   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
To Do List��5   	   $��443.298��6   $��416.672��6-   ��5      �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ Black��6    � Offset$ 0Q�6)   � 5      $ 	#FF66D68A��6   $ 1Q�6-   � 5	      $ 	#FF1B4F63��6   5
      .��5      �  J� RenderTransformOrigin$ 	0.501,0.7&�6    � RowDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5   
   �� $
��Left=�6   $��	60,10,0,0q�6/   $
��Wrap=�6B   $��Script MT Bold)�6V   $��65(�6r   $��
To Do List��6�   $	��Top=�6�   ��6�   Z�  J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 9Q�6#   	   	Direction$		 400Q�62   
   Color$
 White��6B   5      �� 5   
   -   5        $��	TasksList��5      $
��Left=�6#   $	��207��6>   $��110,136,0,0q�6K   $	��Top=�6`   $	��115��6x   ��6�   Z� ��6�   Z� �� 5   
   -   5        $�� ��5      $
��Left=�6   $��43��67   $��
112,88,0,0q�6C   $	��Top=�6W   $��52��6o   ��6z   Z� ��5      �� 5       �� ImageSource$+ %C:\Users\Shiraz\Pictures\addtask1.png��6    j� Stretch$ Uniform=�6Q   5      �� 5   
   -   5        $�� ��5      $
��Left=�6   $��43��67   $��
234,88,0,0q�6C   $	��Top=�6W   $��52��6o   ��6z   Z� ��5      �� 5      $( "C:\Users\Shiraz\Pictures\trash.png��6   $ Uniform=�6N   5       �� 5!   
   -   5         ��Name$ DateList��5!      $
��Left=�6$   $	��207��6?   $��225,136,0,0q�6L   $	��Top=�6a   $	��119��6y   ��6�   Z� ��6�   Z� 5#      5$      