export class groceryItem{
    itemId: number;
    name: string;
    description: string;
    price: number;
    stock: number;
    unit: string;
    department: string;

    // need to add users
  
    constructor(itemId: number, name: string, description: string, price: number, stock: number, unit: string, department: string) {
      this.itemId = itemId;
      this.name = name;
      this.description = description;
      this.price = price;
      this.stock = stock;
      this.unit = unit;
      this.department = department;
    }
}