using System;

public class Product
{
    private string _nameProduct;
    private int _idProduct;
    private float _price;
    private int _quantity;

    public Product(string nameProduct, int idProduct, float price, int quantity) 
    {
        _nameProduct = nameProduct;
        _idProduct = idProduct;
        _price = price;
        _quantity = quantity;
    }

    public float CalculatePrice()
    {
        return _price * _quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetidProduct()
    {
        return _idProduct;
    }

    public float GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}