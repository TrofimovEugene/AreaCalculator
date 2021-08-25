SELECT prod.name [Имя продукта], cat.name [Имя категории]
FROM Products prod
LEFT JOIN ProductsCategory prodcat ON prod.id = prodcat.products_id
INNER JOIN Category cat ON cat.id = prodcat.category_id
ORDER BY prod.name
