   M S B A M L   `   `   `  ����M  IMiPrimerFormulario, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MiPrimerFormularioMiPrimerFormulario  5   	   $    MiPrimerFormulario.Formulario3   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:MiPrimerFormulario     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Formulario3��5	   	   $	��450��6   $	��500��6*   .��5
      � .+�5   
   �� $��Seleccione un producto:��6   $
��Left=�62   $��	49,48,0,0q�6M   $	��Top=�6`   $
��Bold"�6x   $��18(�6�   �� 5   
   -   5        $��cmbProductos��5      $
��Left=�6'   $��
293,52,0,0q�6B   $	��Top=�6V   $	��149��6n   $
��Bold"�6z   $��18(�6�   6�   �� 5   
   $��Precio:��6   $
��Left=�6"   $��
49,132,0,0q�6=   $	��Top=�6Q   $
��Bold"�6i   $��18(�6{   �� 5   
   $��	Cantidad:��6   $
��Left=�6$   $��
49,188,0,0q�6?   $	��Top=�6S   $
��Bold"�6k   $��18(�6}   �� 5   
   -   5        $��txtCantidad��5      $
��Left=�6%   $��293,192,0,0q�6@    �� TextWrapping$
 Wrap=�6U   $�� ��6i   $	��Top=�6q   $	��149��6�   $
��Bold"�6�   $��18(�6�   �� 5   
   -   5        $��	txtPrecio��5       �� 
IsReadOnly . $
��Left=�65   $��293,140,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��149��6�   $
��Bold"�6�   $��18(�6�   	� 5   
   -   5         	�Name$ rbDescuento��5      $��Aplicar descuento de 10%��6+   $
��Left=�6N   $��
49,263,0,0q�6i   $	��Top=�6}   $
��Bold"�6�   $��18(�6�   �� 5   
   -   5        $��btnCalcular��5      $��Calcular Total��6$   $
��Left=�6=   $��
49,322,0,0q�6X   $	��Top=�6l   $��36��6�   $	��135��6�   $��18(�6�   $
��Bold"�6�   6�   �� 5   
   -   5        $��txtTotal��5       . $
��Left=�64   $��293,345,0,0q�6O   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��120��6�   $
��Bold"�6�   $��18(�6�   �� 5   
   $��Total a Pagar:��6   $
��Left=�6)   $��290,306,0,0q�6D   $	��Top=�6Y   $
��Bold"�6q   $��18(�6�   5      5      