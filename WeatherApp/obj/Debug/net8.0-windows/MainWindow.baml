   M S B A M L   `   `   `  ����E  AWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WeatherApp
WeatherApp  5   	       WeatherApp.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WeatherApp     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5
      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Weather App��6   $��28(�6'   $
��Bold"�65   $��Center=�6G   $��0,0,0,20q�6d   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��1��6K   .+�5      �� -   5        $��	CityInput��5      $	��200��6'   $��0,0,10,0q�63   6c   �� 5      -   5        $��Get Weather��5      $	��100��6+   67   5      �� 5   
   $��2��6   $��0,20,0,0q�6"   $��Center=�64   .+�5      �� -   5        $��WeatherOutput��5      $+��%Weather information will appear here.��6-   $��16(�6Z    �� TextAlignment$ Center=�6h   $
��Wrap=�6   5      5      5       