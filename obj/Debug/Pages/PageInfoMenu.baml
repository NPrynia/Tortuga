   M S B A M L   `   `   `  ????B  >Tortuga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Tortuga.PagesTortuga.Pages  5           Tortuga.Pages.PageInfoMenu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Tortuga.Pages     5      _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N? 
FontFamily$  Segoe UI Black)?5
       N? ShowsNavigationUI .   N? Title$ SchemeCafePage??5      .??5      ? ???#f1f7e9 ? ColumnDefinitions 5   
   ?? 5      $	??29* ?6   ?? 5      $	??63* ?6    ? RowDefinitions 5   
   ?? 5      $
??115* ?6   ?? 5      $
??833* ?6   .+?5   
   ?? $??2??6   ???#4bc7cf6%   ?? 5   
   -   5         ??Name$ 
tbNameMenu??5   ;   $??2??6   
???????$??
NameDishes??6O   $??Center=?6a   $??Center=?5      $??80(?6/   ?? 5   
   $??1??6   .+?5      ?? -   5         ??Name$ imgMenu??5      $??/Res/logo.png??6%   $	??400??6<   $	??400??6H   ?? 5       ?? Orientation$ 
Horizontal=?6   $??Center=?62   .+?5       ?? $??35(?6   $??
Цена: ??6*   ?? 5!      -   5        $ tbPrice??5!   7   $??35(?6   $
??2500??6*   67   5"      5$      ?? 5&   
   $??1??6   $??1??6$   $??	0 0 0 100q?64   .??5'      ?? $??40q?6   .+?5(      ?? $??60(?6   $??Описание:??6*   ?? 5)      -   5        $ tbDescription??5)   <   $??40(?6   $??0 30 0 0q?6*   $*??$gfhfghfghhhhhhhhhhhhhhhhhhhfghfghfg:??6S   $	??800??5*      $
??Left=?6'   $
??Wrap=?5+      ?? 5,      $ 
Horizontal=?6   $
??Left=?66   $??	0 100 0 0q?6Q   .+?5-      ?? .+?5.      ?? -   5        $ tbUnit??5.   @   $??35(?6$   $??Грамм:??62   $??
10 0 10 10q?6P   ?? 5/      -   5        $ tbGram??5/   X   $??35(?6$   $??-??62   $??Center=?6;   6X   50      ?? 51      .+?52      ?? $??35(?6$   $??Калорий:??62   $??
10 0 10 10q?6B   ?? 53      -   5        $ 
tbCalories??53   X   $??35(?6$   $??-??62   $??Center=?6;   6X   54      ?? 56      .+?57      ?? $??35(?6$   $??Белки:??62   $??
10 0 10 10q?6@   ?? 58      -   5        $ 	tbProtein??58   X   $??35(?6$   $??-??62   $??Center=?6;   6X   59      ?? 5:      .+?5;      ?? $??35(?6$   $??Жиров:??62   $??
10 0 10 10q?6@   ?? 5<      -	   5        $ tbFat??5<   X   $??35(?6$   $??-??62   $??Center=?6;   6X   5=      ?? 5>      .+?5?      ?? $??35(?6$   $??Углеводов:??62   $??
10 0 10 10q?6D   ?? 5@      -
   5        $ tbCarb??5@   X   $??35(?6$   $??-??62   $??Center=?6;   6X   5A      5B      5D      5E      5J      5K      