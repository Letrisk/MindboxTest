SELECT Products.Name AS ProductName, Categories.Name AS CategoryName
FROM Products
LEFT JOIN ProductsCategories ON ProductsCategories.ProductId = Products.Id
LEFT JOIN Categories ON Categories.Id = ProductsCategories.CategoryId;