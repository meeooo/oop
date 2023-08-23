
Примеры классов для интернет-магазина:
```cs
// Покупатель
public class Customer
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string DateOfBirth { get; set; }
	public Basket CustomerBasket { get; set; }
	public Featured CustomerFeatured { get; set; }
	public Products[] UserHistory { get; set; }
	public float Balance { get; set; }
}

// Продавец
public class Seller
{
	public int Id { get; set; }
	public string Name { get; set; }
	public Stock SellerStock { get; set; }
	public float Balance { get; set; }
}

// Корзина покупателя
public class Basket
{
	public ProductEntry[] Entries { get; set; }
}

// "Избранное" покупателя
public class Featured
{
	public Product[] Products { get; set; }
}

// Продукт
public class Product
{
	public int Id { get; set; }
	public int SellerId { get; set; }
	public string Name { get; set; }
	public string Category { get; set; }
	public string Description { get; set; }
	public float Price { get; set; }
	public int Rating { get; set; }
}

// Вхождение продукта определённого количества (корзина покупателя или запасы продавца)
public class ProductEntry
{
	public Product Item { get; set; }
	public Product Quantity { get; set; }
}

// Запасы товара у продавца
public class Stock
{
	public ProductEntry[] Entries { get; set; }
}
```