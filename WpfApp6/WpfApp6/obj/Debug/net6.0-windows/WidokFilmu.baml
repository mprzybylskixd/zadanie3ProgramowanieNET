   M S B A M L   `   `   `  ����B  >WpfApp6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp6WpfApp6  5          WpfApp6.WidokFilmu   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      'localclr-namespace:WpfApp6     5      $	��400��5      $	��500��5      $��24(�5        � Title  5
      ��  �� Path$ Title�.��5      �  � ColumnDefinitions 5   
   �� 5      $	��180��6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� .��6   Title:6   �� 5   
   $��1��5       ��5!      �� $ Title� �� UpdateSourceTrigger$ PropertyChanged=��� 5&   
   $��1��5'      .��5(      	Director:6   �� 5)   
   $��1��5*      $��1��5+      ��5,      �� $ Director�$ PropertyChanged=��� 51   
   $��2��52      .��53      Publish date:6   (  "System.Windows.Controls.DatePicker  54   
   $��1��55      $��2��56         SelectedDate 57      �� *PublishDate+�� 59   
   $��3��5:      .��5;      
Publisher:6   �� 5<   
   $��1��5=      $��3��5>      ��5?      �� $ 	Publisher�$ PropertyChanged=��� 5D   
   $��4��5E      .��5F      Wiek:6   �� 5G   
   $��1��5H      $��4��5I      ��5J      �� *Wiek+�� 5L   
   $��5��5M      .��5N      Media Type:6   �� 5O   
   $��1��5P      $��5��5Q       �� SelectedItem 5R      �� *	MediaType+.@�5T      �� .��6   DVD6    �� 5U      .��6   BluRay6#   �� 5V      .��6   VHS6    5W      �� 5X   
   -   5        $��2��5Y      $��6��5Z      .��5[      OK6   5\      5]      