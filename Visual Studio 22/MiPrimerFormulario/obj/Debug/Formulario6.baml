   M S B A M L   `   `   `  ����M  IMiPrimerFormulario, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MiPrimerFormularioMiPrimerFormulario  5   	   $    MiPrimerFormulario.Formulario6   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:MiPrimerFormulario     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Formulario6��5	   	   $	��450��6   $	��900��6*   .��5
      � .+�5   
   �� $��Nombre:��6   $
��Left=�6"   $��	56,90,0,0q�6=   $	��Top=�6P   $��18(�6h   $
��Bold"�6v   �� 5   
   -   5        $��	txtNombre��5      $
��Left=�6#   $��
158,93,0,0q�6>    �� TextWrapping$
 Wrap=�6R   $�� ��6f   $	��Top=�6n   $	��138��6�   $��28��6�   $��18(�6�   $
��Bold"�6�   �� 5   
   $��	Apellido:��6   $
��Left=�6$   $��
56,139,0,0q�6?   $	��Top=�6S   $��18(�6k   $
��Bold"�6y   �� 5   
   -   5        $��txtApellido��5      $
��Left=�6%   $��158,142,0,0q�6@   $
 Wrap=�6U   $�� ��6i   $	��Top=�6q   $	��138��6�   $��28��6�   $��18(�6�   $
��Bold"�6�   �� 5   
   $��
Teléfono:��6   $
��Left=�6$   $��
56,188,0,0q�6?   $	��Top=�6S   $��18(�6k   $
��Bold"�6y   �� 5   
   -   5        $��txtTelefono��5      $
��Left=�6%   $��158,191,0,0q�6@   $
 Wrap=�6U   $�� ��6i   $	��Top=�6q   $	��138��6�   $��28��6�   $��18(�6�   $
��Bold"�6�   �� 5   
   $��Edad:��6   $
��Left=�6    $��
56,243,0,0q�6;   $	��Top=�6O   $��18(�6g   $
��Bold"�6u   �� 5   
   -   5        $��txtEdad��5      $
��Left=�6!   $��158,246,0,0q�6<   $
 Wrap=�6Q   $�� ��6e   $	��Top=�6m   $	��138��6�   $��28��6�   $��18(�6�   $
��Bold"�6�   �� 5   
   $	��ID:��6   $
��Left=�6   $��	56,43,0,0q�69   $	��Top=�6L   $��18(�6d   $
��Bold"�6r   �� 5   
   -   5        $��txtId��5      $
��Left=�6   $��
158,46,0,0q�6:   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��138��6�   $��28��6�   $��18(�6�   $
��Bold"�6�   �� 5   
   -   5        $��
btnAgregar��5      $��Agregar��6#   $
��Left=�65   $��
37,304,0,0q�6P   $	��Top=�6d   $��38��6|   $	��120��6�   $��18(�6�   $
��Bold"�6�   ���	#FF42E85B6�   �� 5   
   -   5        $��btnEliminar��5      $��Eliminar��6$   $
��Left=�67   $��184,304,0,0q�6R   $	��Top=�6g   $��38��6   $	��120��6�   $��18(�6�   $
��Bold"�6�   ���	#FF9A61316�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dataGrid��5      $��340,29,36,70q�6#   $��16(�69   $
��Bold"�6G      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *ID+6H     5      $ Nombre��6%   $	 140 6P    65   �� *Nombre+6P     5      $ Apellido��6%   $	 140 6T    67   �� *
Apellido+6T     5      $ 	Teléfono��6%   $	 100 6T    67   �� *
Telefono+6T     5      $
 Edad��6%   $ 80 6L    63   �� *Edad+6L   5      5!      5"      