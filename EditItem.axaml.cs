using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
using System.Collections.Generic;
using System;
using Avalonia.Controls.Shapes;

namespace session12;

public partial class EditItem : Window
{
    public Bitmap bitmapToBind;
    public EditItem()
    {
        InitializeComponent();
        idForRead.Text = Info.products[Info.prodForEdit].id.ToString();
        ImagePath.Source = Info.products[Info.prodForEdit].image;
        nameTovar.Text = Info.products[Info.prodForEdit].name;
        priceTovar.Text = Info.products[Info.prodForEdit].price.ToString();
        quantityTovar.Text = Info.products[Info.prodForEdit].quantity.ToString();
    }
    private async void AddTovarImg_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        OpenFileDialog _openFileDialog = new OpenFileDialog();

        var result = await _openFileDialog.ShowAsync(this);
        if (result == null) return;
        string path = string.Join("", result);

        if (result != null)
        {

            bitmapToBind = new Bitmap(path);
        }
        ImagePath.Source = bitmapToBind;


    }

    private void EditOk_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Info.products[Info.prodForEdit].name = nameTovar.Text;
        Info.products[Info.prodForEdit].quantity = Convert.ToInt32(quantityTovar.Text);
        Info.products[Info.prodForEdit].price = Convert.ToInt32(priceTovar.Text);
        Info.products[Info.prodForEdit].image = bitmapToBind;
       // Catalog catalog = new Catalog();
       // catalog.Show();
        this.Close();
    }

}