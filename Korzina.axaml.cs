using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;

namespace session12;

public partial class Korzina : Window
{

    public int b = 0;
    public int quantityCount = 0;
    public string codeUs;
    public ListBox quantitylistBox = new ListBox();
    public List<Product> products = new List<Product>();
    public List<Product> currentProdSel = new List<Product>();
    public Korzina()
    {
        InitializeComponent();
        A();
    }

    public void A()
    {
        ProdListInKorz.ItemsSource = Info.productsInKorzina.Select(x => new
        {
            x.id,
            x.name,
            x.price,
            x.quantity,
            x.units,
            x.manufacturer,
            x.description,
            x.image,
            x.quantitySelect,
        }).ToList();
    }
    private void ReturnProdEdit_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Catalog cat = new Catalog();
        cat.Show();
        this.Close();

    }

    private void Exit_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Info.productsInKorzina.Clear();
        Info.products.Clear();
        MainWindow mainwindow = new MainWindow();
        mainwindow.Show();
        this.Close();
    }
    
    private void DelBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {

        int ind = (int)((sender as Button)!).Tag!;

        Info.productsInKorzina.RemoveAt(ind);

        if (Info.productsInKorzina  .Count > 0)
        {
            b = 0;
            foreach (Product pr in Info.products)
            {
                b++;
            }
        }
    }


    private void UmenBtn_OnClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {

        int ind = (int)((sender as Button)!).Tag!;
        Info.productsInKorzina[ind].quantitySelect--;
        Info.productsInKorzina[ind].quantitySelect = CheckQuantity(Info.productsInKorzina[ind].quantitySelect,
            Info.productsInKorzina[ind].quantity);
        ProdListInKorz.ItemsSource = Info.productsInKorzina.ToList();


    }

    private void UvelBtn_OnClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        int ind = (int)((sender as Button)!).Tag!;
        Info.productsInKorzina[ind].quantitySelect++;
        Info.productsInKorzina[ind].quantitySelect = CheckQuantity(Info.productsInKorzina[ind].quantitySelect,
          Info.productsInKorzina[ind].quantity);
        ProdListInKorz.ItemsSource = Info.productsInKorzina.ToList();

    }
    private int CheckQuantity(int quantitySel, int quantityMagaz)
    {
        bool check = true;
        if (quantitySel < 1)
        {
            quantitySel = 1;
        }
        else if (quantitySel > quantityMagaz)
        {
            quantitySel = quantityMagaz;
            podschetstoimosti.Text = "Ошибка. Введенное количество товара больше имеющегося в магазине";
        }
        else
        {
            podschetstoimosti.Text = "";
        }
        return quantitySel;
    }
    private void PodschetOrderBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        bool checkDataCorrect = true;
        double allprice = 0;
        int quantity;

        foreach (ProductKorz productSelect in Info.productsInKorzina)
        {
            allprice += productSelect.price * productSelect.quantitySelect;

        }
        podschetstoimosti.Text = "Общая стоимость составляет: " + allprice.ToString() + " руб.";

    }
    
}