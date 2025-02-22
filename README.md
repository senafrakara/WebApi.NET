# ASP.NET Core Web API - Product CRUD Operations

This project is a Web API developed using ASP.NET Core .NET 9, integrated with Microsoft SQL Server (MSSQL). The API handles basic product information and implements CRUD (Create, Read, Update, Delete) operations for products.

### Tools Used
- **ASP.NET Core .NET 9**: The framework used to build the Web API.
- **Entity Framework Core**: The ORM (Object-Relational Mapper) used for database operations.
- **MSSQL**: The database management system used.

---

## Getting Started

### Prerequisites
- **.NET 6 SDK**: You can download and install the .NET 9 SDK from [here](https://dotnet.microsoft.com/en-us/download/dotnet/9.0).
- **Microsoft SQL Server**: You need to set up an MSSQL database. [MSSQL Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) can be used.

### Steps to Run the Project

1. **Download the Project Files**
   Clone or download the project from GitHub or another source to your local machine.

2. **Configure the Database Connection**
   Add the connection string for the database in the `appsettings.json` file:
   
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=ProductDb;User Id=your_user;Password=your_password;"
     }
   }
   ```

3. **Run Database Migrations**
   To set up the database and apply the latest migrations, run the following command in the terminal:

   ```bash
   dotnet ef database update
   ```

4. **Start the API**
   Run the project using the following command in the terminal:

   ```bash
   dotnet run
   ```

   Once the API is started, it will be available by default at `http://localhost:5269/`.

---

## API Endpoints

### 1. **Get All Products** 
- **GET** `/api/products`
- **Description**: Returns a list of all products in the database.

### 2. **Get Product By ID** 
- **GET** `/api/products/{id}`
- **Description**: Returns a product by its ID.

### 3. **Create Product** 
- **POST** `/api/products`
- **Description**: Creates a new product.
- **Body**: 
  ```json
  {
    "ProductStatusId": 1,
    "ProductStatusName": "Active",
    "ProductUrl": "http://producturl.com",
    "Title": "Sample Product",
    "TitleDomestic": "Sample Ürün",
    "DescriptionDomestic": "Sample Ürün Açıklaması",
    "Sku": "SP001",
    "Barcode": "1234567890",
    "OtherCode": "SP-XYZ",
    "Stock": 100,
    "CurrencyName": "USD",
    "Price": 99.99,
    "PriceDiscountedDomestic": 89.99,
    "PriceDiscounted": 79.99,
    "IsFeatured": true,
    "IsElonkyFeatured": false,
    "HasVideo": true,
    "HasPersonalization": false,
    "IsTaxable": true,
    "WhenMade": "2023",
    "WhoMade": "Sample Manufacturer",
    "PersonalizationDescription": "Customizable text",
    "IsDigital": false
  }
  ```

### 4. **Update Product** 
- **PUT** `/api/products/{id}`
- **Description**: Updates an existing product.
- **Body**: Similar to the `Create Product` endpoint, with the required product data.

### 5. **Delete Product** 
- **DELETE** `/api/products/{id}`
- **Description**: Deletes a product by its ID.

---

## Response Model

For CRUD operations, the following response model will be used to return specific fields from the `Product` entity:

```csharp
public class ProductResponse
{
    public string Title { get; set; }
    public string Sku { get; set; }
    public string Barcode { get; set; }
    public decimal Price { get; set; }
    public string TitleDomestic { get; set; }
    public bool HasVideo { get; set; }
    public int Stock { get; set; }
    public string CurrencyName { get; set; }
}
```

### **Mapped Fields:**
- **Title**: The product title.
- **Sku**: The product SKU code.
- **Barcode**: The product barcode number.
- **Price**: The product price.
- **TitleDomestic**: The localized title of the product.
- **HasVideo**: Whether the product has a video.
- **Stock**: The current stock of the product.
- **CurrencyName**: The currency of the price.

---

## Database Model - `Product`

The following model will store the product information and be used for CRUD operations:

```csharp
using System.ComponentModel.DataAnnotations;

public class ProductModel 
{
    [Key]
    public int Id { get; set; }
    public long ProductStatusId { get; set; }
    public string ProductStatusName { get; set; } = string.Empty;
    public string ProductUrl { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string TitleDomestic { get; set; } = string.Empty;
    public string DescriptionDomestic { get; set; } = string.Empty;
    public string Sku { get; set; } = string.Empty;
    public string Barcode { get; set; } = string.Empty;
    public string OtherCode { get; set; } = string.Empty;
    public int Stock { get; set; }
    public string CurrencyName { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public decimal PriceDiscountedDomestic { get; set; }
    public decimal PriceDiscounted { get; set; }
    public bool IsFeatured { get; set; }
    public bool IsElonkyFeatured { get; set; }
    public bool HasVideo { get; set; }
    public bool HasPersonalization { get; set; }
    public bool IsTaxable { get; set; }
    public string WhenMade { get; set; } = string.Empty;
    public string WhoMade { get; set; } = string.Empty;
    public string PersonalizationDescription { get; set; } = string.Empty;
    public bool? IsDigital { get; set; }
}
```

---

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
