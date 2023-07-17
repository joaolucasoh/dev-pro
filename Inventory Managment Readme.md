
**Inventory Management README.md**

```markdown
# Inventory Management

The Inventory Management module provides a function to sort a list of products based on a specified sort key and order.

## Usage

To sort a list of products, use the `SortProducts` method from the `InventoryManagement` class:

```csharp
List<Product> sortedProducts = InventoryManagement.SortProducts(products, sortKey, ascending);
